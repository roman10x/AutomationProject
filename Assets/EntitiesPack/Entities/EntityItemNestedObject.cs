using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Entities
{
    [Serializable]
    public class EntityItemNestedObject
    {
        [SerializeField]
        private string _stringValue;
        [SerializeField]
        private bool _boolValue;
        
        public string StringValue => _stringValue;
        public bool BoolValue => _boolValue;

        [JsonConstructor]
        public EntityItemNestedObject(string stringValue, bool boolValue)
        {
            _stringValue = stringValue;
            _boolValue = boolValue;
        }
    }
}