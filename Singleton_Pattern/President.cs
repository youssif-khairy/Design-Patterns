using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class President
    {
        private static President? _president;

        private static object locking = new object();
        private President() { }

        public static President CreatePresident()
        {
            lock (locking)
            {
                if (_president == null)
                {
                    return _president = new President();
                }
            }
            return _president;
        }
    }
}
