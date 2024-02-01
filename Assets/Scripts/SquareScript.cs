using UnityEngine;

public class SquareScript : MonoBehaviour
{
    public LogicScript logic;
    public Transform snake;
    private SnakeScript _snakeScript;
    private float _timer;

    // Start is called before the first frame update
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        snake = GameObject.FindGameObjectWithTag("Snake").GetComponent<Transform>();
        _snakeScript = snake.GetComponent<SnakeScript>();
    }

    private void Update()
    {
        if (logic.squares.IndexOf(gameObject) == 0)
        {
            _timer += Time.deltaTime;
            if (_timer < logic.gameSpeed)
            {
                _timer += Time.deltaTime;
            }
            else
            {
                _snakeScript.UpdateAll();
                var position = transform.position;
                var x = Mathf.RoundToInt(position.x) + logic.direction.x;
                var y = Mathf.RoundToInt(position.y) + logic.direction.y;
                position = new Vector3(x, y, 0);
                transform.position = position;
                _timer = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6) logic.GameOver();
    }
}