using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public class SimpleClass_DynamicVariable : DynamicVariable<object>
    {
        public SimpleClass_DynamicVariable() { }

        public SimpleClass_DynamicVariable(object value) : base(value) { }

        [field: SerializeReference] public override object Value { get; set; }
    }
}
