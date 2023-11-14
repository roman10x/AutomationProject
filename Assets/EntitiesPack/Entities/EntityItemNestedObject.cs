using System;
using Newtonsoft.Json;

namespace Entities
{
    [Serializable]
    public class EntityItemNestedObject
    {
        public string _stringValue;
        public bool _boolValue;

        [JsonConstructor]
        public EntityItemNestedObject(string stringValue, bool boolValue)
        {
            _stringValue = stringValue;
            _boolValue = boolValue;
        }
    }
}