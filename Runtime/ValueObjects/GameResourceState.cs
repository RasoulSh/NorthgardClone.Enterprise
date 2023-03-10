using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Northgard.Enterprise.ValueObjects
{
    [Serializable]
    public class GameResourceState
    {
        public int count;
        public int bonusCount;
        public int penaltyCount;
        [JsonIgnore] [XmlIgnore] public int TotalCount => count + bonusCount - penaltyCount;
    }
}