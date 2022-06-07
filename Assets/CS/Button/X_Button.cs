using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class X_Button : MonoBehaviour
{
    public void goQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}