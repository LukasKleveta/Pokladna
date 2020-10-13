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
        PoklZaznam NactiZaznam(int idPoklZaznam);
        PoklZaznam VytvorZaznam(PoklZaznam PoklZaznam);
        void UpravZaznam(PoklZaznam poklZaznam);
        void SmazZaznam(PoklZaznam poklZaznam);
    }
}
