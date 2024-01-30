using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    public Transform snake;
    private SquareMetadata _squareMetadata;

    // Start is called before the first frame update
    void Start()
    {
        _squareMetadata = GetComponent<SquareMetadata>();
        snake = GameObject.FindGameObjectWithTag("Snake").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_squareMetadata.index == 1)
        {
            transform.position = snake.position;
        }
        else
        {
            // TODO: Follow the other blocks
        }
    }
}
