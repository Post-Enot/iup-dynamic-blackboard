using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_SimpleClass_DynamicVariable : DynamicVariable<object[]>
    {
        public Array_SimpleClass_DynamicVariable() { }

        public Array_SimpleClass_DynamicVariable(object[] value) : base(value) { }

        [field: SerializeReference] public override object[] Value { get; set; }
    }
}
