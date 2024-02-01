using UnityEngine;

public class FoodSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject food;

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
        Instantiate(food, new Vector3(Random.Range(0, 15), Random.Range(0, 14), 0), Quaternion.identity);
    }
}