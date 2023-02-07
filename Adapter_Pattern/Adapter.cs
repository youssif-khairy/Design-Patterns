using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : ITarget
    {
        private readonly IAdaptee adaptee;

        public Adapter(IAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public string GetRequestString()
        {
            return $"This is combination of Adapter And Adaptee ${adaptee.GetRequestString()}";
        }
    }
}
