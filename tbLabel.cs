//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbLabel
    {
        public int label_id { get; set; }
        public int slice_id { get; set; }
        public string label_note { get; set; }
        public System.DateTime date_in { get; set; }
        public int open_status { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string label_method { get; set; }
        public string label_author { get; set; }
        public string label_file_type { get; set; }
        public string label_structure { get; set; }
        public Nullable<int> label_file_number { get; set; }
        public int scan_id { get; set; }
        public int sp_id { get; set; }
        public string label_title { get; set; }
        public string label_srcfolder { get; set; }
    
        public virtual tbSlice tbSlice { get; set; }
    }
}
