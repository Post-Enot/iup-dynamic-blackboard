using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class UInt16_DynamicVariable : DynamicVariable<ushort>
    {
        public UInt16_DynamicVariable() { }

        public UInt16_DynamicVariable(ushort value) : base(value) { }

        [field: SerializeField] public override ushort Value { get; set; }
    }
}
