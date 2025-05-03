using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarodnaSkupstina.Entiteti;
using FluentNHibernate.Mapping;

namespace NarodnaSkupstina.Mapiranja
{
    internal class PravniAktMapiranja : ClassMap<PravniAkt>
    {
        public PravniAktMapiranja()
        {
            Table("PRAVNI_AKT");

            DiscriminateSubClassesOnColumn("PREDLOZIO");


            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.TipPravnogAkta, "TIP_PRAVNOG_AKTA");

        }
    }

    class PredlogPoslanikaMapiranja : SubclassMap<PredlogPoslanika>
    {
        public PredlogPoslanikaMapiranja()
        {
            DiscriminatorValue("POSLANICI");

            HasManyToMany(x => x.Poslanici)
                .Table("PRAVNI_AKT_PREDLOG_POSLANIKA")
                .ParentKeyColumn("PRAVNI_AKT_ID")
                .ChildKeyColumn("JIBNP")
                .Cascade.All();
        }
    }

    class PredlogBiracaMapiranja : SubclassMap<PredlogBiraca>
    {
        public PredlogBiracaMapiranja()
        {
            DiscriminatorValue("BIRACI");
            Map(x => x.BrojBiraca, "BROJ_BIRACA");
        }
    }

    class PredlogVladeMapiranja : SubclassMap<PredlogVlade>
    {
        public PredlogVladeMapiranja()
        {
            DiscriminatorValue("VLADA");
        }
    }
}
