using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private PlayerUI playerUI;
    // Start is called before the first frame update
    void Start()
    {
        //Find the PlayerUI in the scene and get its component
        GameObject playerUIObject = GameObject.Find("Game Manager");

        if(playerUIObject != null )
        {
            playerUI = playerUIObject.GetComponent<PlayerUI>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("obstacles"))
        {
            if(playerUI != null)
            {
                playerUI.DecreaseLives(1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
