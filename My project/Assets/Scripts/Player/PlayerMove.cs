using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed, horizontalSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        movement.z = Time.deltaTime * moveSpeed;
        //print(Input.GetAxisRaw(Axis.HORIZONTAL));
        float horizontalMove = Input.GetAxisRaw(Axis.HORIZONTAL);
        float currentPosition = transform.position.x;
        if (horizontalMove > 0 && currentPosition <= LevelBoundary.Side)
        {
           movement.x = Time.deltaTime * horizontalSpeed;
        }

        if (horizontalMove < 0 && currentPosition > -LevelBoundary.Side)
        { 
            movement.x = -Time.deltaTime * horizontalSpeed;
        }
        transform.Translate(movement);
    }
}
