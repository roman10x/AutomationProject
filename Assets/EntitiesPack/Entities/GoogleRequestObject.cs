using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Entities
{
    [Serializable]
    public class GoogleRequestObject
    {
        [SerializeField]
        private List<Entity> _entities;
        [SerializeField]
        private GlobalData _global;
        [SerializeField]
        private List<int> _list;

        public List<Entity> Entities => _entities;
        public GlobalData Global => _global;
        public List<int> ListValues => _list;
        
        [JsonConstructor]
        public GoogleRequestObject(List<Entity> entities, GlobalData global, List<int> list)
        {
            _entities = entities;
            _global = global;
            _list = list;
        }
    }
}








