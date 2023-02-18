using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Northgard.Enterprise.ValueObjects
{
    [Serializable]
    public class CharacterConditionState
    {
        public int count;
        public int bonusCount;
        [JsonIgnore] [XmlIgnore] public int TotalCount => count + bonusCount;
    }
}