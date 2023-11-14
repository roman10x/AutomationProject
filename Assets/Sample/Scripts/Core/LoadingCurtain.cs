using System.Collections;
using UnityEngine;

namespace Core
{
    public class LoadingCurtain : MonoBehaviour
    {
        [SerializeField]
        private CanvasGroup _curtain;

        private WaitForSeconds _fadeInWait = new WaitForSeconds(0.03f);

        public void Show()
        {
            gameObject.SetActive(true);
            _curtain.alpha = 1;
        }

        public void Hide() => StartCoroutine(DoFadeIn());

        private IEnumerator DoFadeIn()
        {
            while (_curtain.alpha > 0)
            {
                _curtain.alpha -= 0.03f;
                yield return _fadeInWait;
            }

            gameObject.SetActive(false);
        }
    }
}