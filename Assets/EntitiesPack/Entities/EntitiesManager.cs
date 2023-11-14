using System;
using Cysharp.Threading.Tasks;
using DataManagement;
using Services;

namespace Entities
{
    public class EntitiesManager : IGameService
    {
        private GoogleRequestObject _googleRequestObject;
        
        public GoogleRequestObject GoogleRequestObject => _googleRequestObject;

        public Action<GoogleRequestObject> OnGoogleObjectUpdate;
        
        public async UniTask<bool> TryInitialize()
        {
            var googleObject = await GoogleDataLoader.GetGoogleObject();
            
            if (googleObject == null)
                return false;
            
            SetGoogleObject(googleObject);
            return true;
        }
        
        private void SetGoogleObject(GoogleRequestObject googleRequestObject)
        {
            _googleRequestObject = googleRequestObject;
            OnGoogleObjectUpdate?.Invoke(_googleRequestObject);
        }
    }
}