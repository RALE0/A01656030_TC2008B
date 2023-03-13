// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Here we call the UI elements we will be using in the script to display the score and the timer in the game scene.
using UnityEngine.UI;
// Here we call the scene manager to be able to load the next scene when the player reaches the finish line. 
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Here we create a variable to store the audio source of the finish sound.
    [SerializeField] private AudioSource finishsound;
    // Here we create a variable to store the time the player takes to finish the level. and a bool variable to stop the stopwatch.
    private bool timerRunning = true;
    private float StartTime = 0.0f; 
    // Here we create a variable to store the text component of the timer.
    [SerializeField] private Text timeText;

    // Here we create a variable to store the bool value of the level being completed. This is to avoid the player from touching the finish line more than once.
    private bool lvlCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        // Here we get the audio source component of the finish sound.
        finishsound = GetComponent<AudioSource>();
        // Here we get the text component of the timer. F2 is used to display only 2 decimal places.
        timeText.text = StartTime.ToString("F2");
        // Here we save the current score in the player prefs. This is done so we can display it in another scene, the score scene.
        PlayerPrefs.SetString("CurrentScore", timeText.text);
    }

    void Update()
    {
        // Here we start the stopwatch.
        if (timerRunning == true){
            // Here we add the time since the last frame to the start time.
            StartTime += Time.deltaTime;
            // Here we display the time in the text component.
            timeText.text = StartTime.ToString("F2");
        }
    }
    // Here we create a function to be called when the player touches the finish line.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Here we check if the player has touched the finish line and if the level has not been completed yet. 
        // If both conditions are true, we play the finish sound, stop the stopwatch, save the current score in the player prefs, and load the next level.
        if (collision.gameObject.name =="Player" && !lvlCompleted)
        {
            finishsound.Play();
            Invoke("CompleteLevel", 1f);
            lvlCompleted = true;
            Invoke("STOPstopwatch", 0f);
            PlayerPrefs.SetString("CurrentScore", timeText.text);
        }
    }

    // Here we create a function to load the next level.
    private void CompleteLevel()
    {
        // Here we load the next level.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Here we create a function to stop the stopwatch.
    private void STOPstopwatch()
    {
        timerRunning = false;
    }
}
