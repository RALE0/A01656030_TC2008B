using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private AudioSource finishsound;
    private bool timerRunning = true;
    private float StartTime = 0.0f; 
    [SerializeField] private Text timeText;

    private bool lvlCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        finishsound = GetComponent<AudioSource>();
        timeText.text = StartTime.ToString("F2");
        PlayerPrefs.SetString("CurrentScore", timeText.text);
    }

    void Update()
    {
        if (timerRunning == true){
            StartTime += Time.deltaTime;
            timeText.text = StartTime.ToString("F2");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Player" && !lvlCompleted)
        {
            finishsound.Play();
            Invoke("CompleteLevel", 1f);
            lvlCompleted = true;
            Invoke("STOPstopwatch", 0f);
            PlayerPrefs.SetString("CurrentScore", timeText.text);
        }
    }

    private void CompleteLevel()
    {
        Debug.Log("Level Complete");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void STOPstopwatch()
    {
        timerRunning = false;
    }
}
