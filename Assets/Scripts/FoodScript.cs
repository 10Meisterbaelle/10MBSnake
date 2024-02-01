using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public GameObject snake;
    // Start is called before the first frame update
    void Start()
    {
        snake = GameObject.FindGameObjectWithTag("Snake");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("FoodSpawner").GetComponent<FoodSpawnScript>().SpawnFood();
            snake.GetComponent<SnakeMetadata>().squares.Add(snake.GetComponent<SnakeScript>().SpawnSquare(69, 420));
        }
    }
}
