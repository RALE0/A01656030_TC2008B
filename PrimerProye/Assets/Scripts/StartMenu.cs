// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This script was for the start menu. It has two functions, one for playing the game and the other for quitting the game.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // if we call the function PlayGame, it will load the scene with the index 1, which is the lvl1 scene.
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    // if we call the function QuitGame, it will quit the game(only works in the build).
    public void QuitGame()
    {
        Debug.Log("Quit"); // We can check in the console if the game was quit.
        Application.Quit();
    }
}
