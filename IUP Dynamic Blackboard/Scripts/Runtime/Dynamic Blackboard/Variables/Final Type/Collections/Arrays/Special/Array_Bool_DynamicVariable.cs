using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_Bool_DynamicVariable : DynamicVariable<bool[]>
    {
        public Array_Bool_DynamicVariable() { }

        public Array_Bool_DynamicVariable(bool[] value) : base(value) { }

        [field: SerializeField] public override bool[] Value { get; set; }
    }
}
