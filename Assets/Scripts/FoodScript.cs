using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public GameObject snake;

    public LogicScript logic;

    // Start is called before the first frame update
    private void Start()
    {
        snake = GameObject.FindGameObjectWithTag("Snake");
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("FoodSpawner").GetComponent<FoodSpawnScript>().SpawnFood();
            logic.squares.Add(snake.GetComponent<SnakeScript>().SpawnSquare(69, 420));
        }
    }
}