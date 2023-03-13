// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This script is used to control the player's life and restart the game when the player dies.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    // rigidbody and animator components of the player object are stored in these variables to be used in the script.
    private Rigidbody2D rb;
    private Animator anim;
    // death sound is stored in this variable to be used in the script.
    [SerializeField] private AudioSource deathSound;

    // Start is called before the first frame update
    private void Start() {
        // get the rigidbody and animator components of the player object.
        rb = GetComponent<Rigidbody2D>();
        // get the animator component of the player object.
        anim = GetComponent<Animator>();
    }
    // if the player collides with a trap, the player dies.
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Trap")) {
            Die(); // call the Die method.
        }
}
    // if the player collides with a trap, the player dies.
    private void Die() {
        // play the death animation and sound.
        anim.SetTrigger("death");
        deathSound.Play();
        rb.bodyType = RigidbodyType2D.Static;
    }
    private void Restart() {
        // reload the current scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
