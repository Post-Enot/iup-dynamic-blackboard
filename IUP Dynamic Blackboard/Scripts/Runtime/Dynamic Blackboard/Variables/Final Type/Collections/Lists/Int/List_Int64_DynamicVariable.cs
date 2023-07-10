using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_Int64_DynamicVariable : DynamicVariable<List<long>>
    {
        public List_Int64_DynamicVariable() { }

        public List_Int64_DynamicVariable(List<long> value) : base(value) { }

        [field: SerializeField] public override List<long> Value { get; set; }
    }
}
