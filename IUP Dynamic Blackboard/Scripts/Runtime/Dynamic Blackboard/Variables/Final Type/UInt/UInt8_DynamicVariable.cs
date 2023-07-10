using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class UInt8_DynamicVariable : DynamicVariable<byte>
    {
        public UInt8_DynamicVariable() { }

        public UInt8_DynamicVariable(byte value) : base(value) { }

        [field: SerializeField] public override byte Value { get; set; }
    }
}
