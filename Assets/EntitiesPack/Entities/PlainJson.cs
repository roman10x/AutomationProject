using Newtonsoft.Json;

namespace Entities
{
    public class PlainJson
    {
        private string _stringKey;
        private int _numberKey;

        [JsonConstructor]
        public PlainJson(string stringKey, int numberKey)
        {
            _stringKey = stringKey;
            _numberKey = numberKey;
        }
    }
}