// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This short script is used to rotate objects in the game. It is used in the saw prefab to make it rotate.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    // Update is called once per frame
    private void Update()
    {
        // rotate the object in the z axis. The speed is multiplied by the time to make the rotation smooth. 
        transform.Rotate(0,0,360* speed * Time.deltaTime);
    }
}
