﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTDB.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CTDB.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 欢迎使用昆虫三维影像数据管理客户端
        ///
        ///（一） 主要功能介绍
        ///   本系统按照数据库主要数据表进行功能切分.
        ///
        ///（二） 主要流程
        ///   主要数据表格的及其操作如下列清单所示。
        ///   1 &quot;Species&quot; -&gt; 添加、删除、更改&quot;物种&quot;信息.
        ///   2 &quot;Specimen&quot; -&gt; 添加、删除、更改&quot;标本&quot;信息.
        ///   3 &quot;Equipment&quot; -&gt; 添加、删除、更改&quot;设备&quot;信息.
        ///   4 &quot;Scan&quot; -&gt; 添加、删除、更改&quot;扫描&quot;信息;上传扫描源文件.
        ///   5 &quot;Slice&quot; -&gt; 添加、删除、更改&quot;切片&quot;信息;上传切片文件.
        ///   6 &quot;Label&quot; -&gt; 添加、删除、更改&quot;标记&quot;信息.
        ///   7 &quot;Example&quot; -&gt; 添加、删除、更改&quot;示例&quot;信息;上传、删除示例文件.
        ///   8 &quot;Tag&quot; -&gt; 添加、删除、更改&quot;术语/标签&quot;信息.
        ///
        ///（三） 注意
        ///   &quot;Scan&quot; 是最核心数据所在，在此进入扫描信息管理前需要建立好“标本”和设备信息。
        ///   &quot;Specimen&quot;管理之前需要完善“物种”信息。
        ///   &quot;Example&quot; 管理之前需要完善“标本”信息。
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string help_ct {
            get {
                return ResourceManager.GetString("help_ct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Example
        ///
        ///Manage assistant data related with specimen.
        ///
        ///示范
        ///
        ///管理 标本 相关  二维标本图像、静态三维图、视频等辅助数据。
        ///.
        /// </summary>
        internal static string help_ct_Sample {
            get {
                return ResourceManager.GetString("help_ct_Sample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scan
        ///
        ///Manage assistant data related with specimen.
        ///
        ///扫描
        ///
        ///管理 与 扫描 相关的数据。
        ///
        ///录入数据前需填写好标本信息和扫描仪器信息。
        ///.
        /// </summary>
        internal static string help_ct_Scan {
            get {
                return ResourceManager.GetString("help_ct_Scan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specimen
        ///
        ///Manage assistant data related with specimen.
        ///
        ///
        ///标本管理：
        ///管理 标本 相关的数据。
        ///
        ///录入数据前需准备好物种信息，填写采集、保存、制备等信息
        ///相关的文件独立添加
        ///
        ///.
        /// </summary>
        internal static string help_ct_Specimen {
            get {
                return ResourceManager.GetString("help_ct_Specimen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon th {
            get {
                object obj = ResourceManager.GetObject("th", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
