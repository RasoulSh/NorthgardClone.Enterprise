using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Northgard.Core.EntityBase;
using Northgard.Core.UnityExtensions.Attributes.UnityReadOnlyField;
using UnityEngine;

namespace Northgard.Enterprise.Entities.WorldEntities
{
 
    [Serializable]
    public class Territory : GameObjectEntity
    {
        public bool isCoast;
        public int buildingCapacity;
        [HideInInspector] public List<string> naturalDistricts;
        [ReadOnlyField] public Vector2Int pointInWorld;

        public delegate void TerritoryDelegate(Territory territory);
        public delegate void TerritoryIdDelegate(string territoryId);
    }
}