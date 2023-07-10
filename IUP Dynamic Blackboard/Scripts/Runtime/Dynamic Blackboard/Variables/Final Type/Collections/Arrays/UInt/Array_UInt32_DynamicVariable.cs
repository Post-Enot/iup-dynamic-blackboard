using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_UInt32_DynamicVariable : DynamicVariable<uint[]>
    {
        public Array_UInt32_DynamicVariable() { }

        public Array_UInt32_DynamicVariable(uint[] value) : base(value) { }

        [field: SerializeField] public override uint[] Value { get; set; }
    }
}
