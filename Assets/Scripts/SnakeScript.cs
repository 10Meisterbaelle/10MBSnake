using UnityEngine;

public class SnakeScript : MonoBehaviour
{
    public GameObject square;
    public LogicScript logic;

    // Start is called before the first frame update
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        logic.squares.Add(SpawnSquare(0, 0));
        logic.squares.Add(SpawnSquare(-1, 0));
        logic.squares.Add(SpawnSquare(-2, 0));
    }

    // Update is called once per frame
    public void UpdateAll()
    {
        for (var i = logic.squares.Count - 1; i > 0; i--) // Moves the squares to the next position
            logic.squares[i].transform.position = logic.squares[i - 1].transform.position;
    }

    public GameObject SpawnSquare(float x, float y)
    {
        var spawnedSquare = Instantiate(square, new Vector3(x, y, 0), Quaternion.identity);
        return spawnedSquare;
    }
}