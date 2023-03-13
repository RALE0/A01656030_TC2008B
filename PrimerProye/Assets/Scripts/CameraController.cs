// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This script is used to follow the player's position in the X and Y axis, but not in the Z axis, since it doesn't matter when it's a 2D game.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // The player's transform is assigned to this variable.
    // This is done in the inspector eventhough it's a private variable, thanks to the [SerializeField].
    [SerializeField] private Transform player;

    // Update is called once per frame
    private void Update()
    {
        // The camera's position is set to the player's position, but only in the X and Y axis.
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
