//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dojo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPayment
    {
        public string Payment_ID { get; set; }
        public string Product_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string Date { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Student Student { get; set; }
    }
}
