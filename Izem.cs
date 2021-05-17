using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Izem : Hero
    {
        public override int End
        {
            get
            {
                return base.End + 3;
            }
        }

        public override int For
        {
            get
            {
                return base.For + 3;
            }
        }
    }
}
