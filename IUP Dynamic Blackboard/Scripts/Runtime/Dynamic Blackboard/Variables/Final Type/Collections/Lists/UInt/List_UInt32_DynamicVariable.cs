using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_UInt32_DynamicVariable : DynamicVariable<List<uint>>
    {
        public List_UInt32_DynamicVariable() { }

        public List_UInt32_DynamicVariable(List<uint> value) : base(value) { }

        [field: SerializeField] public override List<uint> Value { get; set; }
    }
}
