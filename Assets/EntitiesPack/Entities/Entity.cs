using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Entities
{
    [Serializable]
    public class Entity
    {
        [SerializeField]
        private int _id;
        [SerializeField]
        private string _name;
        [SerializeField]
        private string _description;
        [SerializeField]
        private int _number;
        [SerializeField]
        private PlainJson _plainJson;
        [SerializeField]
        private List<EntityNestedItem> _nestedList;
        [SerializeField]
        private EntityNestedObject _nestedObject;
        
        public int Id => _id;
        public string Name => _name;
        public string Description => _description;
        public int Number => _number;
        public PlainJson PlainJson => _plainJson;
        public List<EntityNestedItem> NestedList => _nestedList;
        public EntityNestedObject NestedObject => _nestedObject;

        [JsonConstructor]
        public Entity(int id, string name, string description, int number, PlainJson plainJson,
            List<EntityNestedItem> nestedList, EntityNestedObject nestedObject)
        {
            _id = id;
            _name = name;
            _description = description;
            _number = number;
            _plainJson = plainJson;
            _nestedList = nestedList;
            _nestedObject = nestedObject;
        }
    }
}





