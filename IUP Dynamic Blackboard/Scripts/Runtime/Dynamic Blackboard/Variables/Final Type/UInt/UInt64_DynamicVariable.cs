using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class UInt64_DynamicVariable : DynamicVariable<ulong>
    {
        public UInt64_DynamicVariable() { }

        public UInt64_DynamicVariable(ulong value) : base(value) { }

        [field: SerializeField] public override ulong Value { get; set; }
    }
}
