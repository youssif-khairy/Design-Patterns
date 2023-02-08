using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Childs
{
    public class ReadToJSON : IReader
    {
        public string Read()
        {
            return "Read As JSON";
        }
    }
}
