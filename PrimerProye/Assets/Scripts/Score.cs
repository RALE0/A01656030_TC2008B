// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This script is for displaying the score in the game over screen.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //target text objects
    // here we use public variables to be able to selec the text objects in the inspector section.
    public GameObject currentScore;
    public GameObject kiwiScore;

    //target text components
    private Text currentScoreText;
    private Text kiwiScoreText;

    // Start is called before the first frame update
    void Start()
    {
        // get text components
        currentScoreText = currentScore.GetComponent<Text>();
        kiwiScoreText = kiwiScore.GetComponent<Text>();
        //change current score text
        currentScoreText.text = "GAME COMPLETED IN: " + PlayerPrefs.GetString("CurrentScore") + " SECONDS";
        //change kiwi score text
        kiwiScoreText.text = "COLLECTED: " + PlayerPrefs.GetInt("KiwiScore") + "/5";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
