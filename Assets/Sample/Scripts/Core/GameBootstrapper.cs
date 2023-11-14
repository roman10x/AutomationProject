using Cysharp.Threading.Tasks;
using Nora.Services.GameServices;
using UnityEngine;

namespace Core
{
    public class GameBootstrapper : MonoBehaviour
    {
        private static GameBootstrapper _instance;
        
        [SerializeField]
        private LoadingCurtain _loadingCurtain;
        private SceneLoader _sceneLoader;

        public SceneLoader SceneLoader => _sceneLoader;
        public LoadingCurtain CurtainPrefab => _loadingCurtain;

        public static GameBootstrapper Instance => _instance;
       
        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                _instance = this;
                _sceneLoader = new SceneLoader();
                StartGame().Forget();
                DontDestroyOnLoad(gameObject);
            }
        }

        private async UniTask StartGame()
        {
            await _sceneLoader.Load(SceneLoader.Scenes.MainScene);
            await GameServicesHelper.InitGameServices();
        }
    }
}