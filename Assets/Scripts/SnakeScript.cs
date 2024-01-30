using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SnakeScript : MonoBehaviour
{
    public GameObject square;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject snakeBlock1 = SpawnSquare(0, 0, 1);
        GameObject snakeBlock2 = SpawnSquare(-0.25f, 0, 2);
        GameObject snakeBlock3 = SpawnSquare(-0.5f, 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject SpawnSquare(float x, float y, int index)
    {
        GameObject spawnedSquare = Instantiate(square, new Vector3(x, y, 0), Quaternion.identity, GetComponent<Transform>());
        spawnedSquare.GetComponent<SquareMetadata>().index = index;
        return spawnedSquare;
    }
}
