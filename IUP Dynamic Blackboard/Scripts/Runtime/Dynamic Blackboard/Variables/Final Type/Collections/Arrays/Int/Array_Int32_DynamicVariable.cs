using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_Int32_DynamicVariable : DynamicVariable<int[]>
    {
        public Array_Int32_DynamicVariable() { }

        public Array_Int32_DynamicVariable(int[] value) : base(value) { }

        [field: SerializeField] public override int[] Value { get; set; }
    }
}
