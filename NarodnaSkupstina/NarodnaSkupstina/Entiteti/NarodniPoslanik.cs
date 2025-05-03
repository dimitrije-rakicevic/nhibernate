using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstina.Entiteti
{
    public class NarodniPoslanik
    {
        public virtual int Id { get; protected set; }
        public virtual Int64 Jmbg { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string IzbornaLista { get; set; }
        public virtual DateTime DatumRodj { get; set; }
        public virtual string MestoRodj { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Mesto { get; set; }
        public virtual string BrTel { get; set; }
        public virtual string BrMobTel { get; set; }
        public virtual char StalniRadniOdnosFlag { get; set; }
        public virtual PoslanickaGrupa PredsednikPG { get; set; }
        public virtual PoslanickaGrupa ZamenikPG { get; set; }
        public virtual PoslanickaGrupa ClanPG { get; set; }
        public virtual RadnoTelo PredsednikRT { get; set; }
        public virtual RadnoTelo ZamenikRT { get; set; }
        public virtual RadnoTelo ClanRT { get; set; }
        public virtual IList<PredlogPoslanika> PravniAkti { get; set; }
        public virtual IList<VanrednaSednica> Sednice { get; set; }
        public NarodniPoslanik()
        {
            PravniAkti = new List<PredlogPoslanika>();
            Sednice = new List<VanrednaSednica>();
        }
    }
}
