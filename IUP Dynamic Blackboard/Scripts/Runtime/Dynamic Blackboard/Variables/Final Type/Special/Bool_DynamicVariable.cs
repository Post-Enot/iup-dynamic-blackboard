using System;
using UnityEngine;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public sealed class Bool_DynamicVariable : DynamicVariable<bool>
    {
        public Bool_DynamicVariable() { }

        public Bool_DynamicVariable(bool value) : base(value) { }

        [field: SerializeField] public override bool Value { get; set; }
    }
}
