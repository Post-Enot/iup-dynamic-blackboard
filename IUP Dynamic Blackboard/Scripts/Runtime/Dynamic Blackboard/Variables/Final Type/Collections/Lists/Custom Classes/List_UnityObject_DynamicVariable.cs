using System;
using System.Collections.Generic;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class List_UnityObject_DynamicVariable : DynamicVariable<List<UnityObject>>
    {
        public List_UnityObject_DynamicVariable() { }

        public List_UnityObject_DynamicVariable(List<UnityObject> value) : base(value) { }

        [field: SerializeField] public override List<UnityObject> Value { get; set; }
    }
}
