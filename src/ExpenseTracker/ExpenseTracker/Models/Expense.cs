using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExpenseTracker.Models
{
    [DataContract]
    public class Expense
    {
        [DataMember]
        public int ID { get; set;}
        [DataMember]
        public decimal Amount {get; set;}
        [DataMember]
        public Currency Currency { get; set; }
        [DataMember]
        public string Notes { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

    }
}