using System;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class UnityObject_DynamicVariable : DynamicVariable<UnityObject>
    {
        public UnityObject_DynamicVariable() { }

        public UnityObject_DynamicVariable(UnityObject value) : base(value) { }

        [field: SerializeField] public override UnityObject Value { get; set; }
    }
}
