using UnityEngine;

public class FoodSpawnScript : MonoBehaviour
{
    public GameObject food;
    public GameObject snake;
    public LogicScript logic;

    // Start is called before the first frame update
    private void Start()
    {
        Instantiate(food, new Vector3(Random.Range(0, 15), Random.Range(0, 14), 0), Quaternion.identity);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void SpawnFood()
    {
        var foodPosition = new Vector3(Random.Range(0, 15), Random.Range(0, 14), 0);
        foreach (var square in logic.squares)
            if (square.transform.position == foodPosition)
            {
                SpawnFood();
                return;
            }

        Instantiate(food, foodPosition, Quaternion.identity);
    }
}