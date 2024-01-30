using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeScript : MonoBehaviour
{
    public GameObject square;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnSquare();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSquare()
    {
        Instantiate(square, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
