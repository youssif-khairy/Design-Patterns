using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Childs
{
    public class ReadToYAML : IReader
    {
        public string Read()
        {
            return "Read To YAML";
        }
    }
}
