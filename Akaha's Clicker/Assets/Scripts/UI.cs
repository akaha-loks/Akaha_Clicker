using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
   public void LoadScenes(int scenes)
    {
        SceneManager.LoadScene(scenes);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
