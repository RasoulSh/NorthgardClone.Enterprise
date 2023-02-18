using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Northgard.Core.EntityBase;
using Northgard.Core.Enums;

namespace Northgard.Enterprise.Entities.WorldEntities
{
    [Serializable]
    public class NaturalDistrict : GameObjectEntity
    {

        public NaturalResources naturalResource;

        public delegate void NaturalDistrictDelegate(NaturalDistrict naturalDistrict);
    }
}