using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_UInt64_DynamicVariable : DynamicVariable<ulong[]>
    {
        public Array_UInt64_DynamicVariable() { }

        public Array_UInt64_DynamicVariable(ulong[] value) : base(value) { }

        [field: SerializeField] public override ulong[] Value { get; set; }
    }
}
