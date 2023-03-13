// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This Script is used to collect the kiwis and keep track of the score. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Once again we need to import the UI namespace to use the Text component.
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    // We need to keep track of the number of kiwis we have collected.
    private int kiwis;

    // The sound that will play when we collect a kiwi.
    [SerializeField] private AudioSource collectSound;
    
    // The text component that will display the score.
    [SerializeField] private Text kiwiScore;

    private void OnTriggerEnter2D(Collider2D collision) // This method is called when the object this script is attached to collides with another object.
    {
        // If the object we collided with has the tag "Kiwi"...
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            // then we will destroy it and add 1 to the kiwis variable.
            Destroy(collision.gameObject);
            kiwis++;
            // we also play the collect sound.
            collectSound.Play();
            // we update the text component to display the new score.
            kiwiScore.text = kiwis + "/5";
            // and we save the score to the PlayerPrefs.
            PlayerPrefs.SetInt("KiwiScore", kiwis);
        }
    } 
}

