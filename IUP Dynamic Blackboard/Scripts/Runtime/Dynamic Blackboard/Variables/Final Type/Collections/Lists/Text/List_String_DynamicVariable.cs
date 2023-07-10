using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_String_DynamicVariable : DynamicVariable<List<string>>
    {
        public List_String_DynamicVariable() { }

        public List_String_DynamicVariable(List<string> value) : base(value) { }

        [field: SerializeField] public override List<string> Value { get; set; }
    }
}
