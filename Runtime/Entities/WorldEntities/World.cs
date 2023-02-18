using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Northgard.Core.EntityBase;
using Northgard.Enterprise.ValueObjects;
using UnityEngine;

namespace Northgard.Enterprise.Entities.WorldEntities
{
    [Serializable]
    public class World : GameObjectEntity
    {
        public Vector2Int size;
        [HideInInspector] public List<IdPointPair> territories;
        public delegate void WorldDelegate(World world);
        public delegate void WorldIdDelegate(string worldId);
        public delegate void WorldBoundsDelegate(Bounds worldBounds);
    }   
}