using System;
using Newtonsoft.Json;

namespace Entities
{
    [Serializable]
    public class GlobalData
    {
        private string _key;
        private int _number;
        private bool _boolValue;
        private string _stringValue;

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