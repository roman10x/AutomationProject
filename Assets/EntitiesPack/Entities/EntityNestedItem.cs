using System;
using Newtonsoft.Json;

namespace Entities
{
    [Serializable]
    public class EntityNestedItem
    {
        public int _id;
        public string _name;
        public EntityItemNestedObject _nestedObject;

        [JsonConstructor]
        public EntityNestedItem(int id, string name, EntityItemNestedObject nestedObject)
        {
            _id = id;
            _name = name;
            _nestedObject = nestedObject;
        }
    }
}