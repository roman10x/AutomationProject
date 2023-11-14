using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Core
{
    public class SceneLoader
    {
        public enum Scenes
        {
            Initial = 0,
            MainScene = 1,
            GameScene = 2
        }

        public async UniTask Load(Scenes scene)
        {
            GameBootstrapper.Instance.CurtainPrefab.Show();
            await SceneManager.LoadSceneAsync((int)scene);
            GameBootstrapper.Instance.CurtainPrefab.Hide();
        }
    }
}