using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarodnaSkupstina.Entiteti;
using FluentNHibernate.Mapping;

namespace NarodnaSkupstina.Mapiranja
{
    internal class RadniDanMapiranja : ClassMap<RadniDan>
    {
        public RadniDanMapiranja()
        {
            Table("RADNI_DAN");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.VremPeriodRadaOd, "VREM_PERIOD_RADA_OD");
            Map(x => x.VremPeriodRadaDo, "VREM_PERIOD_RADA_DO");
            Map(x => x.BrojPrisutnih, "BROJ_PRISUTNIH");

            References(x => x.Sednica).Column("SEDNICA_ID").LazyLoad();
        }
    }
}
