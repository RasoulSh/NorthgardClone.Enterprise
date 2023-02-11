using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Northgard.Core.EntityBase;
using Northgard.Entities.ValueObjects;
using UnityEngine;

namespace Northgard.Enterprise.Entities.WorldEntities
{
    [Serializable]
    public class World : GameObjectEntity
    {
        public Vector2Int size;
        [JsonIgnore][XmlIgnore] public string PrefabId => prefabId;
        [JsonIgnore][XmlIgnore] public string Title => title;
        [HideInInspector] public List<IdPointPair> territories;
        public delegate void WorldDelegate(World world);
        public delegate void WorldIdDelegate(string worldId);
        public delegate void WorldBoundsDelegate(Bounds worldBounds);
    }   
}