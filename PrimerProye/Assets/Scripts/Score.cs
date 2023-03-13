using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject currentScore;
    public GameObject kiwiScore;

    private Text currentScoreText;
    private Text kiwiScoreText;

    // Start is called before the first frame update
    void Start()
    {
        //target text component
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
