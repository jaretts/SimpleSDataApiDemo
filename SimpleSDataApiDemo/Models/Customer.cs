using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MobileReports.Models
{
    [DataContract]
    public class Customer
    {
        
        public Customer()
        {
            city = "Irvine";
            state = "CA";
            zipcode = "92614";
        }

        [DataMember(Name = "$url")]
        public String relativeUrl
        {
            get
            {
                return this.GetType().Name + "(" + this._id + ")";
            }
        }

        [DataMember(Name = "$key")]
        public String _id { get; set; }

        [DataMember]
        public String customername { get; set; }

        [DataMember]
        public String addressline1 { get; set; }

        [DataMember]
        public String city { get; set; }

        [DataMember]
        public String state { get; set; }

        [DataMember]
        public String zipcode { get; set; }

        [DataMember]
        public String telephoneno { get; set; }

        [DataMember]
        public Double openorderamt { get; set; }
    }
}