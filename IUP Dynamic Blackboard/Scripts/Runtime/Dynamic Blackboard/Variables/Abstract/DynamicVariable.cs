using System;

namespace IUP.Toolkits.DynamicBlackboard
{
    [Serializable]
    public abstract class DynamicVariable<TValue> : BaseDynamicVariable
    {
        public DynamicVariable() { }

        public DynamicVariable(TValue value)
        {
            Value = value;
        }

        public abstract TValue Value { get; set; }
    }
}
