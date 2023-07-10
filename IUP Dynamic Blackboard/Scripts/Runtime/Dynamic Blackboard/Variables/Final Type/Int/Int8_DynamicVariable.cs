using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Int8_DynamicVariable : DynamicVariable<sbyte>
    {
        public Int8_DynamicVariable() { }

        public Int8_DynamicVariable(sbyte value) : base(value) { }

        [field: SerializeField] public override sbyte Value { get; set; }
    }
}
