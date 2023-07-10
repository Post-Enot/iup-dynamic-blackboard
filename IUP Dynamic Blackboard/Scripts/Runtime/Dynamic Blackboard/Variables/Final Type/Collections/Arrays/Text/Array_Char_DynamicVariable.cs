using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_Char_DynamicVariable : DynamicVariable<char[]>
    {
        public Array_Char_DynamicVariable() { }

        public Array_Char_DynamicVariable(char[] value) : base(value) { }

        [field: SerializeField] public override char[] Value { get; set; }
    }
}
