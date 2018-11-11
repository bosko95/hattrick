using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattrick
{
    class Varijable
    {
        private static double _stanjeRacuna = 100.00;
        public static double StanjeRacuna
        {
            get { return _stanjeRacuna; }
            set { _stanjeRacuna = value; }
        }
    }
}
