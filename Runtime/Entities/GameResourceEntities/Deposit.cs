using System;
using Northgard.Core.Enums;

namespace Northgard.Enterprise.Entities.GameResourceEntities
{
    [Serializable]
    public class Deposit
    {
        public GameResourceType resourceType;
        public int amount;
    }
}