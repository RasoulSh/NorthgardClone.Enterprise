using System;
using System.Collections.Generic;
using Northgard.Core.EntityBase;
using Northgard.Enterprise.Entities.WorldEntities;

namespace Northgard.Enterprise.DataSets
{
    [Serializable]
    public class LevelTerritoryDataSet : GameEntity
    {
        public Territory territory;
        public List<string> characters;
        public List<string> buildings;
    }
}