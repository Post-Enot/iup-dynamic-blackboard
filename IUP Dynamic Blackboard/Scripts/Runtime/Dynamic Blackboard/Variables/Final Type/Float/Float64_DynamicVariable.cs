using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Float64_DynamicVariable : DynamicVariable<double>
    {
        public Float64_DynamicVariable() { }

        public Float64_DynamicVariable(double value) : base(value) { }

        [field: SerializeField] public override double Value { get; set; }
    }
}
