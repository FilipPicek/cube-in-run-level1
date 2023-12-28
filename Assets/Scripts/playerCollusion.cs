using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollusion : MonoBehaviour


{
    public playerMovement movement;
    
    void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
