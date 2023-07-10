using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_Char_DynamicVariable : DynamicVariable<List<char>>
    {
        public List_Char_DynamicVariable() { }

        public List_Char_DynamicVariable(List<char> value) : base(value) { }

        [field: SerializeField] public override List<char> Value { get; set; }
    }
}
