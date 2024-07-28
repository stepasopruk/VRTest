#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

public class ExitButton : ButtonUIViewBase
{
    protected override void OnClick()
    {

#if UNITY_EDITOR
        if (EditorApplication.isPlaying)
            EditorApplication.ExitPlaymode();
#endif

        Application.Quit();
    }
}
