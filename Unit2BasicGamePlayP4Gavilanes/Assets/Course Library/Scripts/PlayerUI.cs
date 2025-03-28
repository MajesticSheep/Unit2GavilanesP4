using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    private int score = 0;
    public int lives = 3;

    private PlayerCollision player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score: " + score);
        Debug.Log("Lives: " + lives);

        GameObject playerObject = GameObject.Find("Player");

        if(playerObject != null)
        {
            player = playerObject.GetComponent<PlayerCollision>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }

    public void DecreaseLives(int points)
    {
        lives -= points;
        Debug.Log("Lives: " + lives);

        if(lives == 0)
        {
            Destroy(player.gameObject);
            Debug.Log("Game Over!");

            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
