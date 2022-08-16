using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Service
public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed, horizontalSpeed;
    private float moveDistance;
    private bool canMove = false;

    public float MoveDistance { get => moveDistance; set => moveDistance = value; }
    public bool CanMove { get => canMove; set => canMove = value; }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        movement.z = Time.deltaTime * moveSpeed;
        //print(Input.GetAxisRaw(Axis.HORIZONTAL));
        if(CanMove)
        {
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
            MoveDistance += movement.z;
        }
        transform.Translate(movement); // Model [ transform ]
      
        //StartCoroutine(calDistance());
    }

    //IEnumerator calDistance()
    //{
    //    yield return new WaitForSeconds(0);
    //    moveDistance += 1;
    //}
}
