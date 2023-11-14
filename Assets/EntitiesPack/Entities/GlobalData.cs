using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Entities
{
    [Serializable]
    public class GlobalData
    {
        [SerializeField]
        private string _key;
        [SerializeField]
        private int _number;
        [SerializeField]
        private bool _boolValue;
        [SerializeField]
        private string _stringValue;
        
        public string Key => _key;
        public int Number => _number;
        public bool BoolValue => _boolValue;
        public string StringValue => _stringValue;

        [JsonConstructor]
        public GlobalData(string key, int number, bool boolValue, string stringValue)
        {
            _key = key;
            _number = number;
            _boolValue = boolValue;
            _stringValue = stringValue;
        }
    }
}