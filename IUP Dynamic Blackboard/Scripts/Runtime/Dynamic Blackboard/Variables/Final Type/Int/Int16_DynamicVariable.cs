using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Int16_DynamicVariable : DynamicVariable<short>
    {
        public Int16_DynamicVariable() { }

        public Int16_DynamicVariable(short value) : base(value) { }

        [field: SerializeField] public override short Value { get; set; }
    }
}
