using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject player;


    public Vector3 respawnPosition;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject == player)
        {

            RespawnPlayer();
        }
    }


    private void RespawnPlayer()
    {
        player.transform.position = respawnPosition;
    }
}
