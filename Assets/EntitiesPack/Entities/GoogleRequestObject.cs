using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entities
{
    [Serializable]
    public class GoogleRequestObject
    {
        private List<Entity> _entities;
        private GlobalData _global;
        private List<int> _list;

        [JsonConstructor]
        public GoogleRequestObject(List<Entity> entities, GlobalData global, List<int> list)
        {
            _entities = entities;
            _global = global;
            _list = list;
        }
    }
}








