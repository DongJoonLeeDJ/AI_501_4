using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterProjectPresentation
{
    public class Drug
    {
        public string itemName { get; set; }
        public string entpName { get; set; }

        public Drug(string itemName, string entpName)
        {
            this.itemName = itemName;
            this.entpName = entpName;
        }
    }
}
