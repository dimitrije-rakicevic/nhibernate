using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstina.Entiteti
{
    public class RadnoTelo
    {
        public virtual int Id { get; protected set; }
        public virtual string TipRadnogTela { get; set; }
        public virtual NarodniPoslanik Predsednik { get; set; }
        public virtual NarodniPoslanik Zamenik { get; set; }
        public virtual IList<NarodniPoslanik> Clanovi { get; set; }
        public virtual Prostorija Prostorija { get; set; }
        public RadnoTelo()
        {
            Clanovi = new List<NarodniPoslanik>();
        }
    }
}
