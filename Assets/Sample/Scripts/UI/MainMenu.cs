using Core;
using Cysharp.Threading.Tasks;
using Entities;
using Nora.Services.GameServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI
{
    public class MainMenu : Window
    {
        [SerializeField] private Button _startGameButton;
        [SerializeField] private GameObject _entityDependableObject; // When entity data exist this object will be turned on

        protected override void Initialize()
        {
            _startGameButton.onClick.AddListener(HandleStartGame);
            UpdateStateOfEntityObject().Forget();

            GameServicesHelper.EntitiesManager.OnGoogleObjectUpdate += SetEntityObjectVisibility;
        }

        protected override void Cleanup()
        {
            _startGameButton.onClick.RemoveAllListeners();
            GameServicesHelper.EntitiesManager.OnGoogleObjectUpdate -= SetEntityObjectVisibility;
        }

        private async void HandleStartGame()
        { 
            await GameBootstrapper.Instance.SceneLoader.Load(SceneLoader.Scenes.GameScene);
        }
        
        private async UniTask UpdateStateOfEntityObject()
        {
            _entityDependableObject.SetActive(false);
            var googleObject = GameServicesHelper.EntitiesManager.GoogleRequestObject;
            SetEntityObjectVisibility(googleObject);
            
            if (googleObject == null)
                await GameServicesHelper.EntitiesManager.TryInitialize();
        }

        private void SetEntityObjectVisibility(GoogleRequestObject googleObject)
        {
            _entityDependableObject.SetActive(googleObject != null);
        }
    }
}