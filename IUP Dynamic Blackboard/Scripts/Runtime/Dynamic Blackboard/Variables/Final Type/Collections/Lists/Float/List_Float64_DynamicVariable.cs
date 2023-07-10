using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_Float64_DynamicVariable : DynamicVariable<List<double>>
    {
        public List_Float64_DynamicVariable() { }

        public List_Float64_DynamicVariable(List<double> value) : base(value) { }

        [field: SerializeField] public override List<double> Value { get; set; }
    }
}
