using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScenes : MonoBehaviour
{
    public void BackButton() => SceneManager.LoadScene(0);

    public void StartButton() => SceneManager.LoadScene(1);

    public void ExitButton() =>
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

}
