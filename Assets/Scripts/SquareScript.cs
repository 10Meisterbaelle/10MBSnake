using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    public Transform snake;
    
    // Start is called before the first frame update
    void Start()
    {
        snake = GameObject.FindGameObjectWithTag("Snake").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
