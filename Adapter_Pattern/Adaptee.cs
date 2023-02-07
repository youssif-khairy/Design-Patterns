using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adaptee : IAdaptee
    {
        public string GetRequestString()
        {
            return "This is request string from Main Adaptee Method";
        }
    }
}
