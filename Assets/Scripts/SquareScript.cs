using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    public LogicScript logic;
    public Transform snake;
    private SnakeMetadata _snakeMetadata;
    private float _timer;
    private SnakeScript _snakeScript;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        snake = GameObject.FindGameObjectWithTag("Snake").GetComponent<Transform>();
        _snakeScript = snake.GetComponent<SnakeScript>();
        _snakeMetadata = snake.GetComponent<SnakeMetadata>();
    }

    void Update()
    {
        // Debug.Log(_snakeMetadata.squares);
        
        if (_snakeMetadata.squares.IndexOf(gameObject) == 0)
        {
            _timer += Time.deltaTime;
            if (_timer < _snakeMetadata.gameSpeed)
            {
                _timer += Time.deltaTime;
            }
            else
            {
                _snakeScript.UpdateAll();
                int x = Mathf.RoundToInt(transform.position.x) + logic.direction.x;
                int y = Mathf.RoundToInt(transform.position.y) + logic.direction.y;
                transform.position = new Vector3(x, y, 0);
                _timer = 0;
            }
        }
    }
}
