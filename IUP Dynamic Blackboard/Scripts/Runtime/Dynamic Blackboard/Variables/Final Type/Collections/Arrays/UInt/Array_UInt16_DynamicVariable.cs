using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_UInt16_DynamicVariable : DynamicVariable<ushort[]>
    {
        public Array_UInt16_DynamicVariable() { }

        public Array_UInt16_DynamicVariable(ushort[] value) : base(value) { }

        [field: SerializeField] public override ushort[] Value { get; set; }
    }
}
