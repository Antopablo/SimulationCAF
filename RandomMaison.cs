using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade
{
    class RandomMaison : Random
    {
        private static RandomMaison _intsance;
        public static RandomMaison Instance
        {
            get {
                if (_intsance == null)
                {
                    _intsance = new RandomMaison();
                }
                return _intsance;
            }
            
        }

        private RandomMaison()
        {
        }

    }
}
