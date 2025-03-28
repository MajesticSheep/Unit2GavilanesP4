using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private static int score = 0;
    private static int lives = 3;
    private bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        if (other.CompareTag("Player") && alive)
        {
            Destroy(gameObject);
            lives -= 1;
            Debug.Log("Lives: " + lives);

            if (lives <=0)
            {
                alive = false;
                Debug.Log("Game Over!");
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
            
        }
        else if(other.CompareTag("Fish"))
        {
                Destroy(gameObject);
                score += 1;
                Debug.Log("Score: " + score);
                Destroy(other.gameObject);
        }
            
            
        
    }

}
