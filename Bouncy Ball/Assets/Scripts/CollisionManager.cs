using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField] BallMovement playermovement;
    bool playerIsAcive = true;

    private void Update()
    {
        if(transform.position.y < -10f && playerIsAcive)
        {
            print("player dead");
            playermovement.enabled = false;
            playerIsAcive = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            print("player dead");
            playermovement.enabled = false;
            playerIsAcive = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            print(" congrats game won!!");
        }
    }
}
