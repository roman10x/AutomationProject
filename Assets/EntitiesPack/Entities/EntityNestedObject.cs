using System;
using Newtonsoft.Json;

namespace Entities
{
    [Serializable]
    public class EntityNestedObject
    {
        public string _name;
        public int _number;

        [JsonConstructor]
        public EntityNestedObject(string name, int number)
        {
            _name = name;
            _number = number;
        }
    }
}