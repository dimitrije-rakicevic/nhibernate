using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarodnaSkupstina.Entiteti;
using FluentNHibernate.Mapping;

namespace NarodnaSkupstina.Mapiranja
{
    internal class NarodniPoslanikMapiranja : ClassMap<NarodniPoslanik>
    {
        public NarodniPoslanikMapiranja()
        {
            Table("NARODNI_POSLANIK");

            Id(x => x.Id, "JIBNP").GeneratedBy.TriggerIdentity();

            Map(x => x.Jmbg, "JMBG");
            Map(x => x.LicnoIme, "LICNO_IME");
            Map(x => x.ImeRoditelja, "IME_RODITELJA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.IzbornaLista, "IZBORNA_LISTA");
            Map(x => x.DatumRodj, "DATUM_RODJ");
            Map(x => x.MestoRodj, "MESTO_RODJ");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");
            Map(x => x.Mesto, "MESTO");
            Map(x => x.BrTel, "BR_TEL");
            Map(x => x.BrMobTel, "BR_MOB_TEL");
            Map(x => x.StalniRadniOdnosFlag, "STALNI_RADNI_ODNOSFLAG");

            References(x => x.ClanPG).Column("ID_PG").LazyLoad();

            HasOne(x => x.PredsednikPG).PropertyRef(x => x.Predsednik).Cascade.All();
            HasOne(x => x.ZamenikPG).PropertyRef(x => x.Zamenik).Cascade.All();

            References(x => x.ClanRT).Column("RADNO_TELO_ID").LazyLoad();

            HasOne(x => x.PredsednikRT).PropertyRef(x => x.Predsednik).Cascade.All();
            HasOne(x => x.ZamenikRT).PropertyRef(x => x.Zamenik).Cascade.All();


            HasManyToMany(x => x.PravniAkti)
                .Table("PRAVNI_AKT_PREDLOG_POSLANIKA")
                .ParentKeyColumn("JIBNP")
                .ChildKeyColumn("PRAVNI_AKT_ID")
                .Cascade.All().Inverse();

            HasManyToMany(x => x.Sednice)
                .Table("POSLANICKI_ZAHTEV_SEDNICE")
                .ParentKeyColumn("JIBNP")
                .ChildKeyColumn("SEDNICA_ID")
                .Cascade.All().Inverse();
        }
    }
}
