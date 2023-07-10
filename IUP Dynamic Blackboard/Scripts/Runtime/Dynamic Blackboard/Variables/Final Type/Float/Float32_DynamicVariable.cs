using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Float32_DynamicVariable : DynamicVariable<float>
    {
        public Float32_DynamicVariable() { }

        public Float32_DynamicVariable(float value) : base(value) { }

        [field: SerializeField] public override float Value { get; set; }
    }
}
