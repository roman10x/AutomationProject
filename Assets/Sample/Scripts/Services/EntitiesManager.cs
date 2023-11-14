using System;
using Cysharp.Threading.Tasks;
using DataManagement;
using Entities;
using Services;

namespace Services
{
    public class EntitiesManager : IGameService
    {
        private GoogleRequestObject _googleRequestObject;
        
        public GoogleRequestObject GoogleRequestObject => _googleRequestObject;

        public Action<GoogleRequestObject> OnGoogleObjectUpdate;
        
        public async UniTask<bool> TryInitialize()
        {
            var googleObject = await GoogleDataHelper.GetGoogleObject();
            
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