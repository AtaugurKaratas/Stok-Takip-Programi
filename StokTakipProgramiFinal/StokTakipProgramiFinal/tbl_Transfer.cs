//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakipProgramiFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Transfer
    {
        public int transfer_id { get; set; }
        public Nullable<int> stok_id { get; set; }
        public Nullable<int> miktar { get; set; }
        public Nullable<System.DateTime> gidicegi_tarih { get; set; }
        public Nullable<int> bulundugu_depo_id { get; set; }
        public Nullable<int> gidecegi_depo_id { get; set; }
    }
}
