using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Array_Int16_DynamicVariable : DynamicVariable<short[]>
    {
        public Array_Int16_DynamicVariable() { }

        public Array_Int16_DynamicVariable(short[] value) : base(value) { }

        [field: SerializeField] public override short[] Value { get; set; }
    }
}
