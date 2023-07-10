using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class String_DynamicVariable : DynamicVariable<string>
    {
        public String_DynamicVariable() { }

        public String_DynamicVariable(string value) : base(value) { }

        [field: SerializeField] public override string Value { get; set; }
    }
}
