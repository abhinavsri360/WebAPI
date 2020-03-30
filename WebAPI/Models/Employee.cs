using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Employee
    {
        public long ID { get; set; }
        public string EmpName { get; set; }
        public string Dept { get; set; }
        public string Mail { get; set; }
        public DateTime? DOJ { get; set; }
    }
}