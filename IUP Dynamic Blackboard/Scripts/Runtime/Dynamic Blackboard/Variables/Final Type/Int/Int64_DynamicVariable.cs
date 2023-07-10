using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Int64_DynamicVariable : DynamicVariable<long>
    {
        public Int64_DynamicVariable() { }

        public Int64_DynamicVariable(long value) : base(value) { }

        [field: SerializeField] public override long Value { get; set; }
    }
}
