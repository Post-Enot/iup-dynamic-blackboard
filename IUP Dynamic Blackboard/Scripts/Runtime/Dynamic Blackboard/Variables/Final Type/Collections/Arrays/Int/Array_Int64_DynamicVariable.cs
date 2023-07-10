using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_Int64_DynamicVariable : DynamicVariable<long[]>
    {
        public Array_Int64_DynamicVariable() { }

        public Array_Int64_DynamicVariable(long[] value) : base(value) { }

        [field: SerializeField] public override long[] Value { get; set; }
    }
}
