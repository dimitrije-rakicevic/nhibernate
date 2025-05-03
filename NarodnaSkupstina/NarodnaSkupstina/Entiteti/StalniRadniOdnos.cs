using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstina.Entiteti
{
    public class StalniRadniOdnos : NarodniPoslanik
    {
        public virtual int BrRadneKnjizice { get; set; }
        public virtual int Godine { get; set; }
        public virtual int Meseci { get; set; }
        public virtual int Dani { get; set; }
        public virtual string ImePoslFirme { get; set; }
    }
}
