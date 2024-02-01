using UnityEngine;

public class SnakeScript : MonoBehaviour
{
    public GameObject square;
    private SnakeMetadata _snakeMetadata;

    // Start is called before the first frame update
    void Start()
    {
        _snakeMetadata = GetComponent<SnakeMetadata>();

        GetComponent<SnakeMetadata>().squares.Add(SpawnSquare(0, 0));
        GetComponent<SnakeMetadata>().squares.Add(SpawnSquare(-1, 0));
        GetComponent<SnakeMetadata>().squares.Add(SpawnSquare(-2, 0));
    }

    // Update is called once per frame
    public void UpdateAll()
    {
        for (int i = _snakeMetadata.squares.Count - 1; i > 0; i--)
        {
            _snakeMetadata.squares[i].transform.position = _snakeMetadata.squares[i - 1].transform.position;
        }
    }

    public GameObject SpawnSquare(float x, float y)
    {
        GameObject spawnedSquare = Instantiate(square, new Vector3(x, y, 0), Quaternion.identity);
        return spawnedSquare;
    }
}