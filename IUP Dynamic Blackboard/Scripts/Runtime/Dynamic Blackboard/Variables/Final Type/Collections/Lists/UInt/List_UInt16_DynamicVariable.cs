using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_UInt16_DynamicVariable : DynamicVariable<List<ushort>>
    {
        public List_UInt16_DynamicVariable() { }

        public List_UInt16_DynamicVariable(List<ushort> value) : base(value) { }

        [field: SerializeField] public override List<ushort> Value { get; set; }
    }
}
