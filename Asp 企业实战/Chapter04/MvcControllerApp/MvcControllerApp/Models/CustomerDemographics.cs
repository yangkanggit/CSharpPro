//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcControllerApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            this.Customers = new HashSet<Customers>();
        }
    
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
