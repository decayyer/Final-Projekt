using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kámen_nůžky_papír
{
    public class Hra
    {
        public int SkoreHrac { get; }
        public int SkoreNepritel { get; }
        public Random generatorVoleb = new Random();

        public Hra()
        {
            SkoreHrac = 0;
            SkoreNepritel = 0;
        }
    }
}
