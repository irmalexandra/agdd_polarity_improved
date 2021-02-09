using System;
using System.Collections;
using System.Collections.Generic;
using AGDDPlatformer;
using UnityEngine;
public class Spikes : MonoBehaviour
{

    public GameObject camera_target;
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            camera_target.GetComponent<CameraTarget>().targets.Remove(other.gameObject.transform);
        
            Destroy(other.gameObject);
            StartCoroutine(PlayerKilled());
        }
    }


    IEnumerator PlayerKilled()
    {
        yield return new WaitForSeconds(3);
        GameManager.instance.ResetLevel();
    }
}
