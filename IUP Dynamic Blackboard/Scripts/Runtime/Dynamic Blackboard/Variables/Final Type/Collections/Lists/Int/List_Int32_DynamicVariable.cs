using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_Int32_DynamicVariable : DynamicVariable<List<int>>
    {
        public List_Int32_DynamicVariable() { }

        public List_Int32_DynamicVariable(List<int> value) : base(value) { }

        [field: SerializeField] public override List<int> Value { get; set; }
    }
}
