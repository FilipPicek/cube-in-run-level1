using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidawaysForce = 500f;


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidawaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidawaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }




    }
}
