using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Thierry : Monster, ICuir, IOr
    {
        private int _Cuir;

        public int Cuir
        {
            get { return _Cuir; }
            private set { _Cuir = value; }
        }
        private int _Or;

        public int Or
        {
            get { return _Or; }
            private set { _Or = value; }
        }
        public Thierry()
        {
            //Cuir = De4.Lance();
        }
    }
}
