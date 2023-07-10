using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_Int8_DynamicVariable : DynamicVariable<sbyte[]>
    {
        public Array_Int8_DynamicVariable() { }

        public Array_Int8_DynamicVariable(sbyte[] value) : base(value) { }

        [field: SerializeField] public override sbyte[] Value { get; set; }
    }
}
