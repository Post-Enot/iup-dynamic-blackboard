using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_UInt8_DynamicVariable : DynamicVariable<List<byte>>
    {
        public List_UInt8_DynamicVariable() { }

        public List_UInt8_DynamicVariable(List<byte> value) : base(value) { }

        [field: SerializeField] public override List<byte> Value { get; set; }
    }
}
