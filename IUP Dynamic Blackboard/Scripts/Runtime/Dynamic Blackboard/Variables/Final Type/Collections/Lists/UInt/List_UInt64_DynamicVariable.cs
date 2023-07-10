using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_UInt64_DynamicVariable : DynamicVariable<List<ulong>>
    {
        public List_UInt64_DynamicVariable() { }

        public List_UInt64_DynamicVariable(List<ulong> value) : base(value) { }

        [field: SerializeField] public override List<ulong> Value { get; set; }
    }
}
