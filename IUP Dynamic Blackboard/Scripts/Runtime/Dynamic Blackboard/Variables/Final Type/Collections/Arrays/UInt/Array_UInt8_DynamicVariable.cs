using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_UInt8_DynamicVariable : DynamicVariable<byte[]>
    {
        public Array_UInt8_DynamicVariable() { }

        public Array_UInt8_DynamicVariable(byte[] value) : base(value) { }

        [field: SerializeField] public override byte[] Value { get; set; }
    }
}
