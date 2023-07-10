using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_SimpleClass_DynamicVariable : DynamicVariable<List<object>>
    {
        public List_SimpleClass_DynamicVariable() { }

        public List_SimpleClass_DynamicVariable(List<object> value) : base(value) { }

        [field: SerializeReference] public override List<object> Value { get; set; }
    }
}
