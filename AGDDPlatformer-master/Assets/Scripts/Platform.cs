using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 velocity;
    public bool moving;

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
    //     {
    //         collision.collider.transform.SetParent(transform);
    //     }
    // }
    //
    // private void OnCollisionExit2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
    //     {
    //         collision.collider.transform
    //     }
    // }

    private void FixedUpdate()
    {
        if (moving)
        {
            body += (velocity * Time.deltaTime);
        }
    }
    
}
