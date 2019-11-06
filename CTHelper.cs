using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CTDB
{
    public class CTHelper
    {
        /// <summary>常见路径 desk app current  c</summary>
        public static string CommonPath(string p = "desk")
        {
            switch (p.ToLower().Trim())
            {
                case "c":
                    return @"C:";
                case "app":
                    return System.Windows.Forms.Application.StartupPath;
                case "current":
                    return Environment.CurrentDirectory;
                case "doc":
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                case "desk":
                default:
                    return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }
        /// <summary>警告对话框</summary>
        /// <param name="s">要警告的内容</param>
        /// <returns></returns>
        static public bool AlertYes(string s) { return MessageBox.Show(s, "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes; }
        /// <summary>参数加载</summary>
        /// <param name="file">加密参数文件</param>
        /// <param name="appkey">加密参数</param>
        /// <returns></returns>
        static public string LoadPara(string file, string appkey)
        {
            string connectionString = CTHelper.LoadTxt(file);
            connectionString = CTHelper.Decrypt(connectionString, CTHelper.GetConfig(appkey));
            return connectionString;
        }

        /// <summary>保存数据表</summary>
        /// <param name="s"></param>
        /// <param name="savefile"></param>
        static public string SaveAsTxt(DataTable dt, string savefile = @"C:\Users\Administrator\Desktop\r.txt", bool includeHead = true)
        {
            string s = "";
            if (includeHead)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                    s += dt.Columns[i].ToString() + "\t";
                s += "\r\n";
            }
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    s += dr[i].ToString() + "\t";
                }
                s += "\r\n";
            }


            try
            {
                StreamWriter sw = new StreamWriter(savefile);
                sw.Write(s);
                sw.Close();
                sw.Dispose();
                return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        /// <summary> 写日志文件</summary>
        /// <param name="info">要记录的信息</param>
        /// <param name="f">要记录的日志文件</param>
        public static void AddLog(string info, string f = "")
        {
            if (f.Trim() == "")
                f = CommonPath() + "\\beslog.txt";
            StreamWriter sw = new StreamWriter(f, true);
            sw.WriteLine(info);
            sw.Flush();
            sw.Close();
        }
        /// <summary> 写日志文件</summary>
        /// <param name="begin"></param>
        /// <param name="f"></param>
        /// <param name="info"> 要记录的事件</param>
        public static void AddLog(string info, DateTime begin, string f = "r.log")
        {
            DateTime dtn = DateTime.Now;
            TimeSpan ts = dtn - begin;
            AddLog(info + "\t" + ts.TotalSeconds.ToString() + "s", f);
        }
        /// <summary> 从文本文件中读取 </summary>
        /// <param name="file">指定文件名</param>
        /// <returns></returns>
        static public string LoadTxt(string file)
        {
            string str;
            try
            {
                StreamReader sr = File.OpenText(file);
                str = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                return str;
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
        /// <summary> 从文本文件中按行读取 </summary>
        /// <param name="f">指定文件名</param>
        /// <param name="trimed">是否开启简易空白筛取</param>
        /// <returns></returns>
        static public string[] LoadTxtByLine(string f, bool trimed = false)
        {
            List<string> r = new List<string>();
            StreamReader sr = new StreamReader(f, Encoding.Default);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                r.Add(s);
            }
            sr.Close();
            sr.Dispose();
            if (trimed)
                for (int i = r.Count - 1; i >= 0; i--)
                    if (r[i].Trim() == "")
                        r.RemoveAt(i);
            return r.ToArray();
        }

        /// <summary> 测试连接数据库是否成功 </summary>
        /// <param name="ConnectionString">数据库连接字符串</param>
        /// <returns></returns>
        public static bool DBIsConnect(string ConnectionString)
        {
            //创建连接对象
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);
            bool IsCanConnectioned = false;
            //ConnectionTimeout 在.net 1.x 可以设置 在.net 2.0后是只读属性，则需要在连接字符串设置
            //如：server=.;uid=sa;pwd=;database=PMIS;Integrated Security=SSPI; Connection Timeout=30
            //mySqlConnection.ConnectionTimeout = 1;//设置连接超时的时间
            try
            {
                //Open DataBase打开数据库
                mySqlConnection.Open();
                IsCanConnectioned = true;
            }
            catch
            {
                //Can not Open DataBase 打开不成功 则连接不成功
                IsCanConnectioned = false;
            }
            finally
            {
                //Close DataBase  关闭数据库连接
                mySqlConnection.Close();
            }
            //mySqlConnection   is   a   SqlConnection   object 
            if (mySqlConnection.State == ConnectionState.Closed || mySqlConnection.State == ConnectionState.Broken)
            {
                //Connection   is   not   available  
                return IsCanConnectioned;
            }
            else
            {
                //Connection   is   available  
                return IsCanConnectioned;
            }
        }
        public static bool DBCheck(string sql, string constr)
        {
            bool r = false;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            r = reader.HasRows;
            reader.Close();
            con.Close();
            return r;
        }
        /// <summary>Find a value from sql </summary>
        /// <param name="sql"></param>
        /// <returns>return a string if find, or null not find</returns>
        public static string DBFindValue(string sql, string constr)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                object c = cmd.ExecuteScalar();
                con.Close();
                return c.ToString();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>set value for combbox </summary>
        /// <param name="cb"></param>
        /// <param name="id"></param>
        static public void setControl(ComboBox cb, int id)
        {
            if (cb.Items.Count <= 0) return;
            if (cb.Items[0] is tbSpecies)
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (((tbSpecies)cb.Items[i]).species_id == id)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
            else if (cb.Items[0] is tbEquipment)
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (((tbEquipment)cb.Items[i]).e_id == id)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
            else if (cb.Items[0] is tbSpecimen)
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (((tbSpecimen)cb.Items[i]).sp_id == id)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }

            //else if (cb.Items[0] is vSpecimen)
            //    for (int i = 0; i < cb.Items.Count; i++)
            //    {
            //        if (((vSpecimen)cb.Items[i]).sp_id == id)
            //        {
            //            cb.SelectedIndex = i;
            //            return;
            //        }
            //    }
            else if (cb.Items[0] is tbScan)
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (((tbScan)cb.Items[i]).scan_id == id)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
            else if (cb.Items[0] is tbSlice)
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (((tbSlice)cb.Items[i]).slice_id == id)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
            else if (cb.Items[0] is tbTag)
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (((tbTag)cb.Items[i]).tag_id == id)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
            else if (cb.Items[0] is tbRef)
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if ((cb.Items[i] as tbRef).ref_id == id)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
        }
        /// <summary>set value for combbox </summary>
        /// <param name="cb"></param>
        /// <param name="text"></param>
        static public void setControl(ComboBox cb, string text)
        {
            if (cb.Items.Count <= 0) return;
            if (cb.Items[0] is tbSpecimen)
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (((tbSpecimen)cb.Items[i]).sp_dehydrant == text)
                    {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
        }
        /// <summary>set value for combox with Tag </summary>
        /// <param name="cb">combox name</param>
        /// <param name="rootid">parent tag's id </param>
        /// <param name="sid">selected tag's id, -1 means not select</param>
        static public void setControlTag(ComboBox cb, int rootid, int sid = -1)
        {
            using (CTDBEntities ct = new CTDBEntities())
            {
                var q = from c in ct.tbTag where c.tag_pid == rootid select c;
                cb.DataSource = q.ToList<tbTag>();
                cb.ValueMember = "tag_id";
                cb.DisplayMember = "tag_tag";
                if (sid != -1)
                    CTHelper.setControl(cb, sid);
            }
        }
        /// <summary>set value for combbox </summary>
        /// <param name="cb"></param>
        /// <param name="text"></param>
        static public void LoadControl(ComboBox cb, string table, int id)
        {
            CTDBEntities ct = new CTDBEntities();
            if (table == "tbEquipment")
            {
                cb.DataSource = ct.tbEquipment.ToList<tbEquipment>();
                cb.DisplayMember = "e_nameA";
            }
            else if (table == "tbSpecimen")
            {
                cb.DataSource = FormLogin.LoadDataA("tbSpecimen");
                cb.DisplayMember = "Abstract";
            }
            else if (table == "tbRef")
            {
                cb.DataSource = ct.tbRef.ToList<tbRef>();
                cb.DisplayMember = "cite";
                setControl(cb, id);
            }
        }
        /// <summary>获取选定行号</summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public static int GetRowIndex(DataGridView dg)
        {
            if (dg.Rows.Count > 0)
                if (dg.SelectedRows[0] != null)
                    return dg.SelectedRows[0].Index;
            return -1;
        }
        /// <summary>获取选定行号</summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public static void SetRowIndex(DataGridView dg, int rowIndex = -1)
        {
            if (dg.DataSource != null)
                if (rowIndex > 0)
                {
                    dg.FirstDisplayedScrollingRowIndex = rowIndex;
                    dg.Rows[rowIndex].Selected = true;
                }
        }


        /// <summary>   
        /// 常用方法，列之间加/t，一行一行输出，此文件其实是csv文件，不过默认可以当成Excel打开。   
        /// </summary>   
        /// <remarks>   
        /// using System.IO;   
        /// </remarks>   
        /// <param name="dgv"></param>   
        static public void DataGridViewToExcel(DataGridView dgv)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Execl files (*.xls)|*.xls";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            dlg.CreatePrompt = true;
            dlg.Title = "保存为Excel文件";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                myStream = dlg.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
                string columnTitle = "";
                try
                {
                    //写入列标题   
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        if (i > 0)
                        {
                            columnTitle += "/t";
                        }
                        columnTitle += dgv.Columns[i].HeaderText;
                    }
                    sw.WriteLine(columnTitle);

                    //写入列内容   
                    for (int j = 0; j < dgv.Rows.Count; j++)
                    {
                        string columnValue = "";
                        for (int k = 0; k < dgv.Columns.Count; k++)
                        {
                            if (k > 0)
                            {
                                columnValue += "/t";
                            }
                            if (dgv.Rows[j].Cells[k].Value == null)
                                columnValue += "";
                            else
                                columnValue += dgv.Rows[j].Cells[k].Value.ToString().Trim();
                        }
                        sw.WriteLine(columnValue);
                    }
                    sw.Close();
                    myStream.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        /// <summary> 读取节点中appStrings的子节点配置项的值 </summary>
        /// <param name="elementkey"> key </param>
        public static string GetConfig(string elementkey) { return ConfigurationManager.AppSettings[elementkey].ToString(); }
        /// <summary> 保存节点中appStrings的子节点配置项的值 </summary>
        /// <param name="elementkey"> key </param>
        /// <param name="elementValue"> value </param>
        public static void SetConfig(string elementkey, string elementValue)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[elementkey].Value = elementValue;
            config.Save(ConfigurationSaveMode.Modified);
            //  ConfigurationManager.RefreshSection("appSettings");
        }
        ///<summary>更新连接字符串</summary> 
        ///<param name="key">连接字符串名称</param> 
        ///<param name="conStr">连接字符串内容</param> 
        ///<param name="conProvider">数据提供程序名称</param> 
        public static void UpdateConnectionString(string appName, string key, string conStr, string conProvider = "System.Data.SqlClient")
        {
            // 将当前应用程序的配置文件作为 System.Configuration.Configuration 对象打开
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 存在此连接,则先删除
            if (ConfigurationManager.ConnectionStrings[key] != null)
                config.ConnectionStrings.ConnectionStrings.Remove(key);

            // 新建一个连接字符串
            ConnectionStringSettings newConStr = new ConnectionStringSettings(key, conStr, conProvider);

            // 将新的连接字符串添加到配置文件中. 
            config.ConnectionStrings.ConnectionStrings.Add(newConStr);

            addpathPower(config.FilePath.Replace(@"\\" + appName + ".exe.Config", ""), "Everyone", "FullControl");

            // 保存对配置文件所作的更改 
            config.Save(ConfigurationSaveMode.Modified);

            // 强制重新载入配置文件的ConnectionStrings配置节 
            //ConfigurationManager.RefreshSection(sectionName);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        /// <summary> 为创建的临时文件分配权限 </summary>
        /// <param name="pathname"></param>
        /// <param name="username"></param>
        /// <param name="power"></param>
        /// <remarks>SKY 2007-8-6</remarks>
        static private void addpathPower(string pathname, string username, string power)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(pathname);
            if ((dirinfo.Attributes & FileAttributes.ReadOnly) != 0)
            {
                dirinfo.Attributes = FileAttributes.Normal;
            }
            //取得访问控制列表
            DirectorySecurity dirsecurity = dirinfo.GetAccessControl();
            switch (power)
            {
                case "FullControl":
                    dirsecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
                    break;
                case "ReadOnly":
                    dirsecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.Read, AccessControlType.Allow));
                    break;
                case "Write":
                    dirsecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.Write, AccessControlType.Allow));
                    break;
                case "Modify":
                    dirsecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.Modify, AccessControlType.Allow));
                    break;
            }
        }


        static string encryptKey = "Oyea";    //定义密钥

        #region 加密解密字符串
        /// <summary>加密字符串</summary>  
        /// <param name="str">要加密的字符串</param>  
        /// <returns>加密后的字符串</returns>  
        public static string Encrypt(string str) { return Encrypt(str, encryptKey); }
        /// <summary>解密字符串</summary>  
        /// <param name="str">要解密的字符串</param>  
        /// <returns>解密后的字符串</returns>  
        public static string Decrypt(string str) { return Decrypt(str, encryptKey); }
        /// <summary>加密字符串</summary>  
        /// <param name="str">要加密的字符串</param>  
        /// <returns>加密后的字符串</returns>  
        public static string Encrypt(string str, string ekey)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();   //实例化加/解密类对象   
            byte[] key = Encoding.Unicode.GetBytes(ekey); //定义字节数组，用来存储密钥    
            byte[] data = Encoding.Unicode.GetBytes(str);//定义字节数组，用来存储要加密的字符串  
            MemoryStream MStream = new MemoryStream(); //实例化内存流对象      
            //使用内存流实例化加密流对象   
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data, 0, data.Length);  //向加密流中写入数据      
            CStream.FlushFinalBlock();              //释放加密流      
            return Convert.ToBase64String(MStream.ToArray());//返回加密后的字符串  
        }
        /// <summary>解密字符串</summary>  
        /// <param name="str">要解密的字符串</param>  
        /// <returns>解密后的字符串</returns>  
        public static string Decrypt(string str, string ekey)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();   //实例化加/解密类对象    
            byte[] key = Encoding.Unicode.GetBytes(ekey); //定义字节数组，用来存储密钥    
            byte[] data = Convert.FromBase64String(str);//定义字节数组，用来存储要解密的字符串  
            MemoryStream MStream = new MemoryStream(); //实例化内存流对象      
            //使用内存流实例化解密流对象       
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data, 0, data.Length);      //向解密流中写入数据     
            CStream.FlushFinalBlock();               //释放解密流      
            return Encoding.Unicode.GetString(MStream.ToArray());       //返回解密后的字符串  
        }


        /// <summary>  哈希密码加密(不可还原)  </summary>  
        /// <param name="s">原始字符串</param>  
        /// <param name="saltKey">Salt加密字符串</param>  
        /// <param name="hashName">加密格式(MD5, SHA1, SHA256, SHA384, SHA512.)</param>  
        /// <returns>加密过的密码</returns>  
        static public string EncryptToHashString(string s, string saltKey, string hashName)
        {
            byte[] src = System.Text.Encoding.Unicode.GetBytes(s);
            byte[] saltbuf = Convert.FromBase64String(saltKey);
            byte[] dst = new byte[saltbuf.Length + src.Length];
            byte[] inArray = null;
            System.Buffer.BlockCopy(saltbuf, 0, dst, 0, saltbuf.Length);
            System.Buffer.BlockCopy(src, 0, dst, saltbuf.Length, src.Length);

            System.Security.Cryptography.HashAlgorithm algorithm = System.Security.Cryptography.HashAlgorithm.Create(hashName);
            inArray = algorithm.ComputeHash(dst);

            return Convert.ToBase64String(inArray);
        }
        /// <summary> compute the file's MD5 value </summary>
        /// <param name="fileName">file's name</param>
        /// <returns> the file's MD5 value</returns>
        public static string GetMD5Hash(string fileName)
        {
            if (!File.Exists(fileName)) return string.Empty;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                System.Security.Cryptography.HashAlgorithm md5 = System.Security.Cryptography.MD5.Create();
                return BitConverter.ToString(md5.ComputeHash(fs)).Replace("-", "");
            }
        }
        /// <summary>计算MD5码</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static public string Convert2MD5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            string rstr = "";
            for (int i = 0; i < hash.Length; i++)
                rstr += (hash[i].ToString("X2"));
            return rstr.ToString().ToLower();
        }

        #endregion

        /// <summary> 生成指定范围内的不重复随机数 </summary>
        /// <param name="Number">随机数个数</param>
        /// <param name="minNum">随机数下限</param>
        /// <param name="maxNum">随机数上限</param>
        /// <returns></returns>
        /// <remarks>http://www.jb51.net/article/66255.htm</remarks>
        public static int[] RandomIntArray(int Number, int minNum, int maxNum)
        {
            if (minNum > maxNum) return null;
            int j;
            int[] b;
            if (maxNum - minNum <= Number)
            {
                b = new int[maxNum - minNum + 1];
                for (int i = 0; i <= maxNum - minNum; i++)
                    b[i] = minNum + i;
                return b;
            }
            b = new int[Number];
            Random r = new Random();
            for (j = 0; j < Number; j++)
            {
                int i = r.Next(minNum, maxNum + 1);
                int num = 0;
                for (int k = 0; k < j; k++)
                {
                    if (b[k] == i)
                    {
                        num = num + 1;
                    }
                }
                if (num == 0)
                {
                    b[j] = i;
                }
                else
                {
                    j = j - 1;
                }
            }
            return b;
        }


        /// <summary>判断url是否存在 </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static bool IsUrlExist(string uri)
        {
            HttpWebRequest req = null;
            HttpWebResponse res = null;
            try
            {
                req = (HttpWebRequest)WebRequest.Create(uri);
                req.Method = "HEAD";
                req.Timeout = 100;
                res = (HttpWebResponse)req.GetResponse();
                return (res.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (res != null)
                {
                    res.Close();
                    res = null;
                }
                if (req != null)
                {
                    req.Abort();
                    req = null;
                }
            }
        }

        /// <summary>借用vldi的API进行上传操作 </summary>
        /// <param name="srcpath">原始文件全路径</param>
        /// <param name="dsid">数据集id</param>
        /// <param name="op">操作代码，一般是"upload"</param>
        /// <param name="para">参数</param>
        /// <param name="vcode">授权码-权限验证用</param>
        /// <param name="userid">用户-权限验证用</param>
        /// <returns>上传结果</returns>
        public static string UploadAPI(string srcpath, string dsid, string op, string para, string vcode, string userid)
        {
            List<FormItemModel> formDatas = new List<FormItemModel>();
            //添加文件和内容
            formDatas.Add(new FormItemModel()
            {
                Key = "file",
                Value = Path.GetFileName(srcpath),
                FileName = System.IO.Path.GetFileName(srcpath),
                FileContent = File.OpenRead(srcpath)
            });
            formDatas.Add(new FormItemModel() { Key = "srcpath", Value = srcpath });
            formDatas.Add(new FormItemModel() { Key = "uid", Value = userid });
            formDatas.Add(new FormItemModel() { Key = "dsid", Value = dsid });
            formDatas.Add(new FormItemModel() { Key = "op", Value = op });
            formDatas.Add(new FormItemModel() { Key = "para", Value = para });
            formDatas.Add(new FormItemModel() { Key = "vcode", Value = vcode });

            string r = PostForm(GetConfig("uploadurl"), formDatas);
            return r;
        }

        /// <summary>
        /// 使用Post方法获取字符串结果
        /// </summary>
        /// <param name="url"></param>
        /// <param name="formItems">Post表单内容</param>
        /// <param name="cookieContainer"></param>
        /// <param name="timeOut">默认20秒</param>
        /// <param name="encoding">响应内容的编码类型（默认utf-8）</param>
        /// <returns></returns>
        public static string PostForm(string url, List<FormItemModel> formItems, CookieContainer cookieContainer = null, string refererUrl = null, Encoding encoding = null, int timeOut = 30000)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            #region 初始化请求对象
            request.Method = "POST";
            request.Timeout = timeOut;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.KeepAlive = true;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
            if (!string.IsNullOrEmpty(refererUrl))
                request.Referer = refererUrl;
            if (cookieContainer != null)
                request.CookieContainer = cookieContainer;
            #endregion

            string boundary = "----" + DateTime.Now.Ticks.ToString("x");//分隔符
            request.ContentType = string.Format("multipart/form-data; boundary={0}", boundary);
            //请求流
            var postStream = new MemoryStream();
            #region 处理Form表单请求内容
            //是否用Form上传文件
            var formUploadFile = formItems != null && formItems.Count > 0;
            if (formUploadFile)
            {
                //文件数据模板
                string fileFormdataTemplate =
                    "\r\n--" + boundary +
                    "\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"" +
                    "\r\nContent-Type: application/octet-stream" +
                    "\r\n\r\n";
                //文本数据模板
                string dataFormdataTemplate =
                    "\r\n--" + boundary +
                    "\r\nContent-Disposition: form-data; name=\"{0}\"" +
                    "\r\n\r\n{1}";
                foreach (var item in formItems)
                {
                    string formdata = null;
                    if (item.IsFile)
                    {
                        //上传文件
                        formdata = string.Format(
                            fileFormdataTemplate,
                            item.Key, //表单键
                            item.FileName);
                    }
                    else
                    {
                        //上传文本
                        formdata = string.Format(
                            dataFormdataTemplate,
                            item.Key,
                            item.Value);
                    }

                    //统一处理
                    byte[] formdataBytes = null;
                    //第一行不需要换行
                    if (postStream.Length == 0)
                        formdataBytes = Encoding.UTF8.GetBytes(formdata.Substring(2, formdata.Length - 2));
                    else
                        formdataBytes = Encoding.UTF8.GetBytes(formdata);
                    postStream.Write(formdataBytes, 0, formdataBytes.Length);

                    //写入文件内容
                    if (item.FileContent != null && item.FileContent.Length > 0)
                    {
                        using (var stream = item.FileContent)
                        {
                            byte[] buffer = new byte[1024];
                            int bytesRead = 0;
                            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                            {
                                postStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
                //结尾
                var footer = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");
                postStream.Write(footer, 0, footer.Length);

            }
            else
            {
                request.ContentType = "application/x-www-form-urlencoded";
            }
            #endregion

            request.ContentLength = postStream.Length;

            #region 输入二进制流
            if (postStream != null)
            {
                postStream.Position = 0;
                //直接写入流
                Stream requestStream = request.GetRequestStream();

                //byte[] buffer = new byte[1024];
                byte[] buffer = new byte[4096];
                int bytesRead = 0;
                while ((bytesRead = postStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    requestStream.Write(buffer, 0, bytesRead);
                }

                ////debug
                //postStream.Seek(0, SeekOrigin.Begin);
                //StreamReader sr = new StreamReader(postStream);
                //var postStr = sr.ReadToEnd();
                postStream.Close();//关闭文件访问
            }
            #endregion

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (cookieContainer != null)
                {
                    response.Cookies = cookieContainer.GetCookies(response.ResponseUri);
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader myStreamReader = new StreamReader(responseStream, encoding ?? Encoding.UTF8))
                    {
                        string retString = myStreamReader.ReadToEnd();
                        return retString;
                    }
                }
            }
            catch (Exception exex)
            { return exex.ToString(); }
        }

        public static string DownloadFile(string url, string des = "")
        {
            string r = "";
            try
            {
                if (des == "")
                    des = CommonPath("app") + "\\tmp\\" + Path.GetFileName(url);
                if (!Directory.Exists(Path.GetDirectoryName(des)))
                    Directory.CreateDirectory(Path.GetDirectoryName(des));
                File.Delete(des);
                using (System.Net.WebClient webClient = new System.Net.WebClient())
                    webClient.DownloadFile(url, des);
            }
            catch { }
            return r;
        }

        /// <summary>模拟Post</summary>
        /// <param name="Url">提交的URL</param>
        /// <param name="postDataStr">参数</param>
        /// <returns></returns>
        public static string HttpPost(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }


        /// <summary>Use a safe method get image</summary>
        /// <param name="Filename">image's path</param>
        /// <returns></returns>
        public static Bitmap LoadBitmap(string Filename)
        {
            //创建一个bitmap类型的bmp变量来读取文件。
            Bitmap bmp = new Bitmap(Filename);
            //新建第二个bitmap类型的bmp2变量，我这里是根据我的程序需要设置的。
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            //将第一个bmp拷贝到bmp2中
            using (Graphics draw = Graphics.FromImage(bmp2))
                draw.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Dispose();//释放bmp文件资源
            return bmp2;
        }
        /// <summary> 生成缩略图 </summary>
        /// <param name="ts">原始文件</param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public static Bitmap CreateDemoImage(string ts, int w = 40, int h = 40)
        {
            Bitmap br = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(br);
            if (ts.Contains(".wav") || ts.Contains(".wma"))
            {
                g.DrawString("Sound", SystemFonts.DefaultFont, Brushes.Orange, 0, 0);
            }
            else if (ts.Contains(".bmp") || ts.Contains(".jpg") || ts.Contains(".png") || ts.Contains(".tif"))
            {
                Bitmap b = LoadBitmap(ts);
                g.DrawImage(b, new Rectangle(0, 0, w, h), new Rectangle(0, 0, b.Width, b.Height), GraphicsUnit.Pixel);
                b.Dispose();
            }
            g.Dispose();
            return br;
        }



        //定义API函数
        [DllImport("kernel32.dll")]
        static extern uint SetThreadExecutionState(ExecutionFlag flags);

        [Flags]
        enum ExecutionFlag : uint
        {
            System = 0x00000001,
            Display = 0x00000002,
            Continuous = 0x80000000,
        }

        /// <summary>阻止系统休眠，直到线程结束恢复休眠策略 </summary>
        /// <param name="includeDisplay">是否阻止关闭显示器</param>
        public static void PreventSleep(bool includeDisplay = false)
        {
            if (includeDisplay)
                SetThreadExecutionState(ExecutionFlag.System | ExecutionFlag.Display | ExecutionFlag.Continuous);
            else
                SetThreadExecutionState(ExecutionFlag.System | ExecutionFlag.Continuous);
        }

        /// <summary>
        ///恢复系统休眠策略
        /// </summary>
        public static void RestoreSleep() { SetThreadExecutionState(ExecutionFlag.Continuous); }

        /// <summary>
        ///重置系统休眠计时器
        /// </summary>
        /// <param name="includeDisplay">是否阻止关闭显示器</param>
        public static void ResetSleepTimer(bool includeDisplay = false)
        {
            if (includeDisplay)
                SetThreadExecutionState(ExecutionFlag.System | ExecutionFlag.Display);
            else
                SetThreadExecutionState(ExecutionFlag.System);
        }
    }

    /// <summary>
    /// 表单数据项
    /// </summary>
    public class FormItemModel
    {
        /// <summary>
        /// 表单键，request["key"]
        /// </summary>
        public string Key { set; get; }
        /// <summary>
        /// 表单值,上传文件时忽略，request["key"].value
        /// </summary>
        public string Value { set; get; }
        /// <summary>
        /// 是否是文件
        /// </summary>
        public bool IsFile
        {
            get
            {
                if (FileContent == null || FileContent.Length == 0)
                    return false;

                if (FileContent != null && FileContent.Length > 0 && string.IsNullOrWhiteSpace(FileName))
                    throw new Exception("上传文件时 FileName 属性值不能为空");
                return true;
            }
        }
        /// <summary>
        /// 上传的文件名
        /// </summary>
        public string FileName { set; get; }
        /// <summary>
        /// 上传的文件内容
        /// </summary>
        public Stream FileContent { set; get; }
    }

}
