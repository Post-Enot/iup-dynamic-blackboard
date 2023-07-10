using System;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_UnityObject_DynamicVariable : DynamicVariable<UnityObject[]>
    {
        public Array_UnityObject_DynamicVariable() { }

        public Array_UnityObject_DynamicVariable(UnityObject[] value) : base(value) { }

        [field: SerializeField] public override UnityObject[] Value { get; set; }
    }
}
