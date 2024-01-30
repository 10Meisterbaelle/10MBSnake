using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SnakeScript : MonoBehaviour
{
    public GameObject square;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject snakeBlock1 = SpawnSquare(0, 0);
        
        GameObject snakeBlock2 = SpawnSquare(-0.25f, 0);
        GameObject snakeBlock3 = SpawnSquare(-0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject SpawnSquare(float x, float y)
    {
        GameObject spawnedSquare = Instantiate(square, new Vector3(x, y, 0), Quaternion.identity);
        return spawnedSquare;
    }
}
