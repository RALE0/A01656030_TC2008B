// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This was made for allowing the player to stick on the moving platform. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick2Platform : MonoBehaviour
{
    // When the player collides with the platform, it will be a child of the platform. Meaning that it will move with it. By copying the position of the platform.
    private void OnTriggerEnter2D(Collider2D collision) {
        // We check if the object that collided with the platform is the player.
        if (collision.gameObject.name == "Player")   
        {
            // We make the player a child of the platform.
            collision.gameObject.transform.SetParent(transform);
        }
    }

    // When the player leaves the platform, it will no longer be a child of the platform.
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.name == "Player")   
        {
            // We make the player a child of the platform, with null as a parameter.
            collision.gameObject.transform.SetParent(null);
        }
    }
     
}
