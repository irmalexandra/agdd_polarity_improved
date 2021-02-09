using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySystem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject button_display;

    private GameObject _player_in_range;
    private bool _taken;
    private SpriteRenderer self_sprite_renderer;
    private BoxCollider2D self_box_collider;

    private void Start()
    {
       
        _taken = false;
        self_sprite_renderer = GetComponent<SpriteRenderer>();
        self_box_collider = GetComponent<BoxCollider2D>();

    }

    private void Update()
    {
        if (_player_in_range && !_taken)
        {
            button_display.SetActive(true);
            
            if (Input.GetKey("e"))
            {
               
                /*SpriteRenderer new_renderer = _player_in_range.AddComponent<SpriteRenderer>();
                new_renderer.sprite = _key_sprite;
                new_renderer.size = new Vector2(0.5f, 0.5f);
                new_renderer.sortingOrder = 2;*/
                var key_transform = transform;
                key_transform.parent = _player_in_range.transform;
                self_sprite_renderer.sortingOrder = 2;
                _taken = true;
                key_transform.position = new Vector3(_player_in_range.transform.position.x, 0.5f, 0f);
                key_transform.localScale = new Vector3(0.5f, 0.5f, 0f);
                self_box_collider.enabled = false;

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
