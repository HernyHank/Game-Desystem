using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void QuitButton()
    {
        Application.Quit();

        //in editor testing
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }


}
