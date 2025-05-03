using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstina.Entiteti
{
    public class PoslanickaGrupa
    {
        public virtual int Id { get; protected set; }
        public virtual string JedinstvenoIme { get; set; }
        public virtual NarodniPoslanik Predsednik { get; set; }
        public virtual NarodniPoslanik Zamenik { get; set; }
        public virtual IList<NarodniPoslanik> Clanovi { get; set; }
        public virtual IList<Prostorija> Prostorije { get; set; }
        public PoslanickaGrupa()
        {
            Clanovi = new List<NarodniPoslanik>();
            Prostorije = new List<Prostorija>();
        }
    }
}
