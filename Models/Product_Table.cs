//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Product_Store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Table
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public string Category { get; set; }
        public Nullable<int> Price { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}
