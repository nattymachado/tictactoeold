using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyBehaviour : MonoBehaviour {


    public float MoveSpeed = 0.1f;
    public float HighWave = 0.1f;

    private Vector3 _startPosition;
    private Vector3 _currentDirection;
    private float _remainingTime;

    // Use this for initialization
    void Start()
    {
        _startPosition = transform.position;
    }

    

    // Update is called once per frame
    void Update()
    { 
    
        if (transform.position.x > 10f)
        {
            transform.position = new Vector3();
        }
        transform.position = new Vector3(transform.position.x + MoveSpeed, Mathf.Sin(Time.time * HighWave) , 0f);
        
    }
}
