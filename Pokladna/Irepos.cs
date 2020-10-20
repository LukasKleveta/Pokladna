using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
    public interface Irepos
    {
        List<PoklZaznam> NactiVse();
        List<PoklZaznam> NactiMesic(int rok, int mesic);
        PoklZaznam NactiZaznam(int idPoklZaznam);
        PoklZaznam VytvorZaznam(PoklZaznam PoklZaznam);
        void UpravZaznam(PoklZaznam poklZaznam);
        void SmazZaznam(PoklZaznam poklZaznam);
    }
}
