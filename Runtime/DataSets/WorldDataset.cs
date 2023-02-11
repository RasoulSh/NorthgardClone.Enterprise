using System;
using System.Collections.Generic;
using Northgard.Core.EntityBase;
using Northgard.Enterprise.Entities.WorldEntities;

namespace Northgard.Enterprise.DataSets
{
    [Serializable]
    public class WorldDataset : GameEntity
    {
        public World world;
        public List<Territory> territories;
        public List<NaturalDistrict> naturalDistricts;
    }
}