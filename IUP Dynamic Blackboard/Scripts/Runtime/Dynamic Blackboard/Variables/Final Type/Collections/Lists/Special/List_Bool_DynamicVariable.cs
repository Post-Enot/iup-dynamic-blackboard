using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_Bool_DynamicVariable : DynamicVariable<List<bool>>
    {
        public List_Bool_DynamicVariable() { }

        public List_Bool_DynamicVariable(List<bool> value) : base(value) { }

        [field: SerializeField] public override List<bool> Value { get; set; }
    }
}
