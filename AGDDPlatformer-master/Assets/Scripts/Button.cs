using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] to_destroy;
    public GameObject button_display;
    public GameObject button_face;
    
    private bool _playerInRange;
    private bool _pressed;
    private SpriteRenderer _button_face_renderer;
    private Color _original_button_color;
    void Start()
    {
        _playerInRange = false;
        _pressed = false;
        _button_face_renderer = button_face.GetComponent<SpriteRenderer>();
        _original_button_color = _button_face_renderer.color;

    }

    private void Update()
    {
        if (_playerInRange && !_pressed)
        {
            button_display.SetActive(true);
            if (!Input.GetKey("e")) return;
            foreach (var item in to_destroy)
            {
                item.SetActive(false);
            }
            _pressed = true;
            Color new_color = new Color(_original_button_color.r - 0.5f, _original_button_color.g, _original_button_color.b);
            _button_face_renderer.color = new_color;
        }
        else
        {
            button_display.SetActive(false);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        _playerInRange = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _playerInRange = false;
    }
}
