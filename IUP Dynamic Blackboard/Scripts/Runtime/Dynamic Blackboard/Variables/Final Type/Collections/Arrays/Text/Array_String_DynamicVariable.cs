using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_String_DynamicVariable : DynamicVariable<string[]>
    {
        public Array_String_DynamicVariable() { }

        public Array_String_DynamicVariable(string[] value) : base(value) { }

        [field: SerializeField] public override string[] Value { get; set; }
    }
}
