using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
	using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("NewGame button pressed");
        
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Debug.Log("Quit button pressed");

        #if UNITY_EDITOR
        	EditorApplication.isPlaying = false;
        #else
        	Application.Quit();
        #endif
    }
}
