using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Char_DynamicVariable : DynamicVariable<char>
    {
        public Char_DynamicVariable() { }

        public Char_DynamicVariable(char value) : base(value) { }

        [field: SerializeField] public override char Value { get; set; }
    }
}
