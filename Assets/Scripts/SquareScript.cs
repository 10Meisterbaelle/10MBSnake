using System;
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
                var position = transform.position;
                int x = Mathf.RoundToInt(position.x) + logic.direction.x;
                int y = Mathf.RoundToInt(position.y) + logic.direction.y;
                position = new Vector3(x, y, 0);
                transform.position = position;
                _timer = 0;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            logic.GameOver();
        }
    }
}