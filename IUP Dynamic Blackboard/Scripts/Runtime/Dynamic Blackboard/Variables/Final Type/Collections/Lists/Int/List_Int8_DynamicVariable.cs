using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_Int8_DynamicVariable : DynamicVariable<List<sbyte>>
    {
        public List_Int8_DynamicVariable() { }

        public List_Int8_DynamicVariable(List<sbyte> value) : base(value) { }

        [field: SerializeField] public override List<sbyte> Value { get; set; }
    }
}
