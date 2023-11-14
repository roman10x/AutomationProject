using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Entities
{
    [Serializable]
    public class EntityNestedObject
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private int _number;

        public string Name => _name;
        public int Number => _number;
        
        [JsonConstructor]
        public EntityNestedObject(string name, int number)
        {
            _name = name;
            _number = number;
        }
    }
}