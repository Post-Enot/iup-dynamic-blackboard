using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_Float32_DynamicVariable : DynamicVariable<float[]>
    {
        public Array_Float32_DynamicVariable() { }

        public Array_Float32_DynamicVariable(float[] value) : base(value) { }

        [field: SerializeField] public override float[] Value { get; set; }
    }
}
