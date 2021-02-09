using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject key;
    public GameObject button_display;
    private GameObject _player_in_range;
    private bool _opened = false;
    private Collider2D self_collider;


    private void Start()
    {
        self_collider = GetComponent<Collider2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if (_player_in_range && !_opened)
        {
         
            
            button_display.SetActive(true);
            if (Input.GetKey("e"))
            {
                foreach (Transform child in  _player_in_range.transform)
                {
                    if (child.gameObject == key)
                    {
                        transform.parent.gameObject.SetActive(false);
                        child.gameObject.SetActive(false);
                    }
                }
            }
        }
        else
        {
            button_display.SetActive(false);
        }
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        _player_in_range = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _player_in_range = null;
    }
}
