using System;
using System.Collections;
using System.Collections.Generic;
using AGDDPlatformer;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public Transform startPos;
    public float stop_timer;
    public float speed;

    private float _timer;
    public Vector3 nextPos;
    private bool stop;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        stop = false;
        _timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
            if(_timer > )
        }
        else if(stop)
        {
            Debug.Log(_timer);
            _timer += Time.deltaTime;
            if (_timer >= stop_timer)
            {
                stop = false;
            }
        }
        else
        {
            stop = false;
        }
        
        if (transform.position == pos1.position && _timer <= 0)
        {
            _timer = stop_timer;
            stop = true;
            nextPos = pos2.position;
        }    
        if (transform.position == pos2.position && _timer <= 0)
        {
            stop = true;
            _timer = stop_timer;
            nextPos = pos1.position;
        }
        
        



    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
