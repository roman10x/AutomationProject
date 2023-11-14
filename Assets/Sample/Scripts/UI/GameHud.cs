using Core;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class GameHud : Window
    {
        [SerializeField] private Button _closeGameButton;

        protected override void Initialize()
        {
            _closeGameButton.onClick.AddListener(HandleCloseGame);
        }

        protected override void Cleanup()
        {
            _closeGameButton.onClick.RemoveAllListeners();
        }

        private async void HandleCloseGame()
        { 
            await GameBootstrapper.Instance.SceneLoader.Load(SceneLoader.Scenes.MainScene);
        }
    }
}