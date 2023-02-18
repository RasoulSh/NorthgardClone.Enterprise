using System;
using System.Collections.Generic;
using Northgard.Core.EntityBase;
using Northgard.Core.Enums;
using UnityEngine;

namespace Northgard.Enterprise.Entities.ClanEntities
{
    [Serializable]
    public class Clan : GameEntity
    {
        public ClanTypes clanType;
        public string title;
        public Texture2D icon;
        public List<BuildingTypes> availableBuildings;
        
    }
}