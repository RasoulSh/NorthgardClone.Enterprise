using System;
using System.Collections.Generic;
using Northgard.Core.EntityBase;
using Northgard.Enterprise.Entities.PlayerEntities;
using Northgard.Enterprise.Entities.WorldEntities;

namespace Northgard.Enterprise.DataSets
{
    [Serializable]
    public class LevelDataSet : GameEntity
    {
        public World gameWorld;
        public List<LevelTerritoryDataSet> territories;
        public List<Player> players;
    }
}