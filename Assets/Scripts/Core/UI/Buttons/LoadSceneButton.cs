using UnityEngine;
using UnityEngine.SceneManagement;

namespace VRTest.Core.UI
{
    public sealed class LoadSceneButton : ButtonUIViewBase
    {
        [SerializeField] private string sceneName;

        protected override void OnClick()
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}