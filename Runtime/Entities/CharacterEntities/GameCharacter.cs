using System;
using Northgard.Core.EntityBase;
using Northgard.Core.UnityExtensions.Attributes.UnityHideIfEmpty;
using Northgard.Core.UnityExtensions.Attributes.UnityReadOnlyField;
using Northgard.Enterprise.ValueObjects;

namespace Northgard.Enterprise.Entities.CharacterEntities
{
    [Serializable]
    public class GameCharacter : GameObjectEntity
    {
        public CharacterConditionState hp;
        public CharacterConditionState attack;
        public CharacterConditionState strength;
        public CharacterConditionState attackSpeed;
        public CharacterConditionState attackRange;
        [HideIfEmpty][ReadOnlyField] public string assignedBuildingId;
    }
}