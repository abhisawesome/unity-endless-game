using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{   
    public GameObject player;
    private void Start() {
        player = GameObject.Find("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }else{
            if (collision.tag == "Player")
            {
                // player.GetComponent<PlayerController>().health -= 1;
                Destroy(player.gameObject);
            }
        }
    }
}
