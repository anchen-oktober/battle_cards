using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public void MainMenu()
    {
        Debug.Log("MainMenu button pressed");
        
        SceneManager.LoadScene(0);
    }
}
