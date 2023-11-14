using UnityEngine;

namespace UI
{
    public class Window : MonoBehaviour
    {
        private void Start()
        {
            Initialize();
        }

        private void OnDestroy()
        {
            Cleanup();
        }

        protected virtual void Initialize(){}
        protected virtual void Cleanup(){}
    }
}