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
                //force puissance 3
                return base.End + 3;
            }
        }
        // Premier commentaire Linh

        // Deuxième commentaire Linh
        public override int For
        {
            get
            {
                // il est fort min izem
                return base.For + 3;
            }
        }
    }

    // Encore un commentaire
}
