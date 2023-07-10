using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class UInt32_DynamicVariable : DynamicVariable<uint>
    {
        public UInt32_DynamicVariable() { }

        public UInt32_DynamicVariable(uint value) : base(value) { }

        [field: SerializeField] public override uint Value { get; set; }
    }
}
