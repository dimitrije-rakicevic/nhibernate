using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarodnaSkupstina.Entiteti;
using FluentNHibernate.Mapping;

namespace NarodnaSkupstina.Mapiranja
{
    internal class RadnoTeloMapiranja : ClassMap<RadnoTelo>
    {
        public RadnoTeloMapiranja()
        {
            Table("RADNO_TELO");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.TipRadnogTela, "TIP_RADNOG_TELA");

            HasMany(x => x.Clanovi).KeyColumn("RADNO_TELO_ID").LazyLoad().Cascade.All().Inverse();

            References(x => x.Predsednik).Column("JIBNPP").LazyLoad();
            References(x => x.Zamenik).Column("JIBNPZ").LazyLoad();
            References(x => x.Prostorija).Column("BROJ_PROSTORIJE").LazyLoad();
        }
    }
}
