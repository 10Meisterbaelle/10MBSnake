using TMPro;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public GameObject snake;

    public LogicScript logic;
    public TMP_Text scoreCounter;

    // Start is called before the first frame update
    private void Start()
    {
        snake = GameObject.FindGameObjectWithTag("Snake");
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        scoreCounter = GameObject.FindGameObjectWithTag("ScoreCounter").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6) // if the food is touched by the snake
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("FoodSpawner").GetComponent<FoodSpawnScript>().SpawnFood();
            logic.squares.Add(snake.GetComponent<SnakeScript>().SpawnSquare(69, 420));
            scoreCounter.text = (logic.squares.Count - 3).ToString();
        }
    }
}