using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private AudioSource finishsound;

    private bool lvlCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        finishsound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Player" && !lvlCompleted)
        {
            finishsound.Play();
            Invoke("CompleteLevel", 1f);
            lvlCompleted = true;
        }
    }

    private void CompleteLevel()
    {
        Debug.Log("Level Complete");
    }
}
