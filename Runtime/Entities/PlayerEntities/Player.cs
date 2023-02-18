using System;
using System.Collections.Generic;
using Northgard.Core.EntityBase;
using Northgard.Core.Enums;
using Northgard.Enterprise.Entities.BuildingEntities;
using Northgard.Enterprise.Entities.GameResourceEntities;
using UnityEngine;

namespace Northgard.Enterprise.Entities.PlayerEntities
{
    [Serializable]
    public class Player : GameEntity
    {
        public string playerName;
        public Color playerColor;
        public string clanId;
        public GameResourceCatalog gameResources;
        public List<string> discoveredTerritories;
        public List<string> ownedTerritories;
        public List<Building> createdBuildings;
        public List<string> ownedBuildings;
        public List<string> people;
        public PlayerState playerState;
    }
}