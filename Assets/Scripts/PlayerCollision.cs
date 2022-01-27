using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject player;
    float coins;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().tag == "Collectable")
        {
            coins = PlayerPrefs.GetFloat("coins") + 25;
            PlayerPrefs.SetFloat("coins", coins);
            Debug.Log("Shit69420");
            col.gameObject.SetActive(false);
            Destroy(col);
        }
    }
}
