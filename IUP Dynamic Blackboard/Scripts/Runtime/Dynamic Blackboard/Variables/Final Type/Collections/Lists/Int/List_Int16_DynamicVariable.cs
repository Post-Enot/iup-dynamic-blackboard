using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_Int16_DynamicVariable : DynamicVariable<List<short>>
    {
        public List_Int16_DynamicVariable() { }

        public List_Int16_DynamicVariable(List<short> value) : base(value) { }

        [field: SerializeField] public override List<short> Value { get; set; }
    }
}
