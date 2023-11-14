using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Entities
{
    [Serializable]
    public class EntityNestedItem
    {
        [SerializeField]
        private int _id;
        [SerializeField]
        private string _name;
        [SerializeField]
        private EntityItemNestedObject _nestedObject;

        public int Id => _id;
        public string Name => _name;
        public EntityItemNestedObject NestedObject => _nestedObject;
        
        [JsonConstructor]
        public EntityNestedItem(int id, string name, EntityItemNestedObject nestedObject)
        {
            _id = id;
            _name = name;
            _nestedObject = nestedObject;
        }
    }
}