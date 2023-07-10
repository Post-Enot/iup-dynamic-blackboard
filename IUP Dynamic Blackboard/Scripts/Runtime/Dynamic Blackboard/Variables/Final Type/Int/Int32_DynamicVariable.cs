using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Int32_DynamicVariable : DynamicVariable<int>
    {
        public Int32_DynamicVariable() { }

        public Int32_DynamicVariable(int value) : base(value) { }

        [field: SerializeField] public override int Value { get; set; }
    }
}
