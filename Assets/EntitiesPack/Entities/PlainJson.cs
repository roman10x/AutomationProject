using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Entities
{
    [Serializable]
    public class PlainJson
    {
        [SerializeField]
        private string _stringKey;
        [SerializeField]
        private int _numberKey;

        public string StringKey => _stringKey;
        public int NumberKey => _numberKey;
        
        [JsonConstructor]
        public PlainJson(string stringKey, int numberKey)
        {
            _stringKey = stringKey;
            _numberKey = numberKey;
        }
    }
}