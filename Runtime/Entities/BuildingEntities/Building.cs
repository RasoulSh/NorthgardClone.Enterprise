using System;
using Northgard.Core.EntityBase;
using Northgard.Core.Enums;

namespace Northgard.Enterprise.Entities.BuildingEntities
{
    [Serializable]
    public class Building : GameObjectEntity
    {
        public BuildingTypes buildingType;
        public string territoryId;
    }
}