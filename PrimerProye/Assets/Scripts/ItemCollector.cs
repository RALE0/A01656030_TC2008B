using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int kiwis = 0;

    [SerializeField] private AudioSource collectSound;
    
    [SerializeField] private Text kiwiScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            Destroy(collision.gameObject);
            kiwis++;
            collectSound.Play();
            kiwiScore.text = "Kiwis: " + kiwis;
        }
    } 
}

