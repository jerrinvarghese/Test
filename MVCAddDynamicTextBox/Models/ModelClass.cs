using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAddDynamicTextBox.Models
{
    public class ModelClass
    {
    }

    public class Cust
    {
        public string Name { get; set; }
    }
    public class Custodel
    {
        public IEnumerable<Cust> custList { get; set; }
    }
}