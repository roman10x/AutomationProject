using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entities
{
    [Serializable]
    public class Entity
    {
        public int _id;
        public string _name;
        public string _description;
        public int _number;
        private PlainJson _plainJson;
        public List<EntityNestedItem> _nestedList;
        public EntityNestedObject _nestedObject;

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





