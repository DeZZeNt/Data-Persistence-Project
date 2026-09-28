using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainScripts : MonoBehaviour
{
    public InputField NameInputField;

    // Carries the name typed on this screen across the scene load, since
    // this object (and its InputField) is destroyed once "main" loads and
    // MainManager has no other way to reach it.
    public static string PendingPlayerName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void PlayGame()
    {
        if (NameInputField != null)
        {
            PendingPlayerName = NameInputField.text;
        }

        SceneManager.LoadScene("main");
    }
}
