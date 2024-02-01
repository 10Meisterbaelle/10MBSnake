using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject snake;
    public Vector3Int direction = Vector3Int.right;
    public List<GameObject> squares = new();
    public float gameSpeed = 0.25f;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && direction != Vector3Int.down)
            direction = Vector3Int.up;
        else if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && direction != Vector3Int.left)
            direction = Vector3Int.right;
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && direction != Vector3Int.up)
            direction = Vector3Int.down;
        else if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && direction != Vector3Int.right) direction = Vector3Int.left;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Destroy(snake);
        foreach (var square in squares)
        {
            Destroy(square);
        }
        Destroy(GameObject.FindGameObjectWithTag("Food"));
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}