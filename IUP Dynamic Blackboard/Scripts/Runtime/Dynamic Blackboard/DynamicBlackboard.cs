using System;
using System.Collections.Generic;
using IUP.Toolkits.SerializableCollections;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace IUP.Toolkits.DynamicBlackboard
{
    /// <summary>
    /// Сериализуемый класс, позволяющий хранить набор любых сериализуемых Unity данных с учётом полиморфизма.
    /// </summary>
    [Serializable]
    public class DynamicBlackboard
    {
        /// <summary>
        /// Количество переменных.
        /// </summary>
        public int VariablesCount => Variables.Count;

        [SerializeField] private SK_SRV_Dictionary<string, BaseDynamicVariable> _variablesSerializationShell = new();

        private Dictionary<string, BaseDynamicVariable> Variables => _variablesSerializationShell.Value;

        /// <summary>
        /// Проверяет, содержит ли blackboard переменную с переданным названием.
        /// </summary>
        /// <param name="variableName">Название переменной.</param>
        /// <returns>True, если blackboard содержит переменную с переданным названием;
        /// иначе false.</returns>
        public bool ContainsVariableWithName(string variableName)
        {
            return Variables.ContainsKey(variableName);
        }

        /// <summary>
        /// Проверяет, содержит ли blackboard переменную с переданным названием указанного типа.
        /// </summary>
        /// <typeparam name="TVariableValue">Тип переменной.</typeparam>
        /// <param name="variableValue">Название переменной.</param>
        /// <returns>True, если blackboard содержит переменную с переданным названием
        /// указанного типа; иначе false.</returns>
        public bool ContainsVariableWithNameAndType<TVariableValue>(string variableValue)
        {
            bool containsVariableWithName = ContainsVariableWithName(variableValue);
            if (!containsVariableWithName)
            {
                return false;
            }
            BaseDynamicVariable variable = GetVariable<BaseDynamicVariable>(variableValue);
            return variable is DynamicVariable<TVariableValue>;
        }

        /// <summary>
        /// Удаляет переменную из blackboard по названию, если blackboard содержит переменную с
        /// переданным названием.
        /// </summary>
        /// <param name="variableName">Название переменной.</param>
        public void RemoveVariableByName(string variableName)
        {
            if (!ContainsVariableWithName(variableName))
            {
                throw new NotImplementedException(); // TODO.
            }
            _ = Variables.Remove(variableName);
        }

        /// <summary>
        /// Изменяет название переменной blackboard, если blackboard содержит переменную с
        /// переданным названием.
        /// </summary>
        /// <param name="oldVariableName">Старое название переменной.</param>
        /// <param name="newVariableName">Новое название переменной.</param>
        public void RenameVariable(string oldVariableName, string newVariableName)
        {
            if (!ContainsVariableWithName(oldVariableName))
            {
                throw new NotImplementedException(); // TODO.
            }
            if (ContainsVariableWithName(newVariableName))
            {
                throw new NotImplementedException(); // TODO.
            }
            BaseDynamicVariable variable = Variables[oldVariableName];
            _ = Variables.Remove(oldVariableName);
            Variables.Add(newVariableName, variable);
        }

        /// <summary>
        /// Очищает blackboard, удаляя все переменные.
        /// </summary>
        public void Clear()
        {
            Variables.Clear();
        }

        /// <summary>
        /// Добавляет в blackboard переменную с переданным названием и значением указанного типа, если
        /// blackboard не содержит переменную с переданным названием; иначе выкидывает исключение.
        /// </summary>
        /// <typeparam name="TVariableValue">Тип переменной.</typeparam>
        /// <param name="variableName">Название переменной.</param>
        /// <param name="variableValue">Значение переменной.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddVariable<TVariableValue>(string variableName, TVariableValue variableValue)
        {
            if (ContainsVariableWithName(variableName))
            {
                throw new NotImplementedException(); // TODO.
            }

            BaseDynamicVariable variable;

            if (variableValue is Array)
            {
                variable = variableValue switch
                {
                    // Целочисленные со знаком:
                    sbyte[]       array_int8_VariableValue        => new Array_Int8_DynamicVariable(array_int8_VariableValue),
                    short[]       array_int16_VariableValue       => new Array_Int16_DynamicVariable(array_int16_VariableValue),
                    int[]         array_int32_VariableValue       => new Array_Int32_DynamicVariable(array_int32_VariableValue),
                    long[]        array_int64_VariableValue       => new Array_Int64_DynamicVariable(array_int64_VariableValue),

                    // Целочисленные без знака:
                    byte[]        array_uint8_VariableValue       => new Array_UInt8_DynamicVariable(array_uint8_VariableValue),
                    ushort[]      array_uint16_VariableValue      => new Array_UInt16_DynamicVariable(array_uint16_VariableValue),
                    uint[]        array_uint32_VariableValue      => new Array_UInt32_DynamicVariable(array_uint32_VariableValue),
                    ulong[]       array_uint64_VariableValue      => new Array_UInt64_DynamicVariable(array_uint64_VariableValue),

                    // С плавающей запятой:
                    float[]       array_float32_VariableValue     => new Array_Float32_DynamicVariable(array_float32_VariableValue),
                    double[]      array_float64_VariableValue     => new Array_Float64_DynamicVariable(array_float64_VariableValue),

                    // Текстовые:
                    char[]        array_char_VariableValue        => new Array_Char_DynamicVariable(array_char_VariableValue),
                    string[]      array_string_VariableValue      => new Array_String_DynamicVariable(array_string_VariableValue),

                    // Специальные:
                    bool[]        array_bool_VariableValue        => new Array_Bool_DynamicVariable(array_bool_VariableValue),

                    // Собственные классы:
                    UnityObject[] array_UnityObject_VariableValue => new Array_UnityObject_DynamicVariable(array_UnityObject_VariableValue),
                    object[]                                      => new Array_SimpleClass_DynamicVariable(variableValue as object[]),

                    // Исключение:
                    _ => throw new NotImplementedException() // TODO.
                };
            }
            else if (variableValue is List<object>)
            {
                variable = variableValue switch
                {
                    // Целочисленные со знаком:
                    List<sbyte>       list_int8_VariableValue        => new List_Int8_DynamicVariable(list_int8_VariableValue),
                    List<short>       list_int16_VariableValue       => new List_Int16_DynamicVariable(list_int16_VariableValue),
                    List<int>         list_int32_VariableValue       => new List_Int32_DynamicVariable(list_int32_VariableValue),
                    List<long>        list_int64_VariableValue       => new List_Int64_DynamicVariable(list_int64_VariableValue),

                    // Целочисленные без знака:
                    List<byte>        list_uint8_VariableValue       => new List_UInt8_DynamicVariable(list_uint8_VariableValue),
                    List<ushort>      list_uint16_VariableValue      => new List_UInt16_DynamicVariable(list_uint16_VariableValue),
                    List<uint>        list_uint32_VariableValue      => new List_UInt32_DynamicVariable(list_uint32_VariableValue),
                    List<ulong>       list_uint64_VariableValue      => new List_UInt64_DynamicVariable(list_uint64_VariableValue),

                    // С плавающей запятой:
                    List<float>       list_float32_VariableValue     => new List_Float32_DynamicVariable(list_float32_VariableValue),
                    List<double>      list_float64_VariableValue     => new List_Float64_DynamicVariable(list_float64_VariableValue),

                    // Текстовые:
                    List<char>        list_char_VariableValue        => new List_Char_DynamicVariable(list_char_VariableValue),
                    List<string>      list_string_VariableValue      => new List_String_DynamicVariable(list_string_VariableValue),

                    // Специальные:
                    List<bool>        list_bool_VariableValue        => new List_Bool_DynamicVariable(list_bool_VariableValue),

                    // Собственные классы:
                    List<UnityObject> list_UnityObject_VariableValue => new List_UnityObject_DynamicVariable(list_UnityObject_VariableValue),
                    List<object>                                     => new List_SimpleClass_DynamicVariable(variableValue as List<object>),

                    // Исключение:
                    _ => throw new NotImplementedException() // TODO.
                };
            }
            else
            {
                variable = variableValue switch
                {
                    // Целочисленные со знаком:
                    sbyte       int8_VariableValue        => new Int8_DynamicVariable(int8_VariableValue),
                    short       int16_VariableValue       => new Int16_DynamicVariable(int16_VariableValue),
                    int         int32_VariableValue       => new Int32_DynamicVariable(int32_VariableValue),
                    long        int64_VariableValue       => new Int64_DynamicVariable(int64_VariableValue),

                    // Целочисленные без знака:
                    byte        uint8_VariableValue       => new UInt8_DynamicVariable(uint8_VariableValue),
                    ushort      uint16_VariableValue      => new UInt16_DynamicVariable(uint16_VariableValue),
                    uint        uint32_VariableValue      => new UInt32_DynamicVariable(uint32_VariableValue),
                    ulong       uint64_VariableValue      => new UInt64_DynamicVariable(uint64_VariableValue),

                    // С плавающей запятой:
                    float       float32_VariableValue     => new Float32_DynamicVariable(float32_VariableValue),
                    double      float64_VariableValue     => new Float64_DynamicVariable(float64_VariableValue),

                    // Текстовые:
                    char        char_VariableValue        => new Char_DynamicVariable(char_VariableValue),
                    string      string_VariableValue      => new String_DynamicVariable(string_VariableValue),

                    // Специальные:
                    bool        bool_VariableValue        => new Bool_DynamicVariable(bool_VariableValue),
                    
                    // Собственные классы:
                    UnityObject unityObject_VariableValue => new UnityObject_DynamicVariable(unityObject_VariableValue),
                    _                                     => new SimpleClass_DynamicVariable(variableValue)
                };
            }
            Variables.Add(variableName, variable);
        }

        /// <summary>
        /// Возвращает значение переменной blackboard с переданным названием указанного типа, если
        /// blackboard содержит переменную с переданным названием указанного типа; иначе выбрасывает исключение.
        /// </summary>
        /// <typeparam name="TVariableValue">Тип значения переменной.</typeparam>
        /// <param name="variableName">Название переменной.</param>
        /// <returns>Значение переменной указанного типа с переданным названием.</returns>
        public TVariableValue GetVariableValue<TVariableValue>(string variableName)
        {
            DynamicVariable<TVariableValue> variable = GetDynamicVariable<TVariableValue>(variableName);
            return variable.Value;
        }

        /// <summary>
        /// Устанавливает значение переменной blackboard с переданным названием указанного типа, если
        /// blackboard содержит переменную с переданным названием указанного типа; иначе выбрасывает исключение.
        /// </summary>
        /// <typeparam name="TVariableValue">Тип значения переменной.</typeparam>
        /// <param name="variableName">Название переменной.</param>
        /// <param name="variableValue">Значение переменной.</param>
        public void SetVariableValue<TVariableValue>(string variableName, TVariableValue variableValue)
        {
            DynamicVariable<TVariableValue> variable = GetDynamicVariable<TVariableValue>(variableName);
            variable.Value = variableValue;
        }

        private DynamicVariable<TVariableValue> GetDynamicVariable<TVariableValue>(string variableName)
        {
            return GetVariable<DynamicVariable<TVariableValue>>(variableName);
        }

        private TVariable GetVariable<TVariable>(string variableName)
        {
            if (!ContainsVariableWithName(variableName))
            {
                throw new NotImplementedException(); // TODO.
            }
            if (Variables[variableName] is not TVariable variable)
            {
                throw new NotImplementedException(); // TODO.
            }
            return variable;
        }
    }
}
