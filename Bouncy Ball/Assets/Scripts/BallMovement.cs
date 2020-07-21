using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Rigidbody ball;

    [SerializeField] int forwardForce = 100;
    [SerializeField] int upForce = 1000;
    [SerializeField] int downForce = 500;
    [SerializeField] int sidewaysForce = 250;

    // Update is called once per frame
    void Update()
    {
        ball.AddForce(0, 0, forwardForce * Time.deltaTime);

        UpAndDownMovement();

        SidewaysMovement();
    }



    private void SidewaysMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ball.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }


        if (Input.GetKey(KeyCode.D))
        {
            ball.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }


    private void UpAndDownMovement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ball.AddForce(0, upForce * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ball.AddForce(0, -downForce * Time.deltaTime, 0);
        }
    }


}
