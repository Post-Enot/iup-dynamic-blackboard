using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_Float32_DynamicVariable : DynamicVariable<List<float>>
    {
        public List_Float32_DynamicVariable() { }

        public List_Float32_DynamicVariable(List<float> value) : base(value) { }

        [field: SerializeField] public override List<float> Value { get; set; }
    }
}
