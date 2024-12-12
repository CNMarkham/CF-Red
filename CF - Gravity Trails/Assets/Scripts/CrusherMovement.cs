using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherMovement : MonoBehaviour
{
    public float speed;
    public GameObject left;
    public GameObject right;

    private void FixedUpdate()
    {
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);

        transform.position = newPosition;

        if(transform.position.x <= left.transform.position.x || transform.position.x >= right.transform.position.x)
        {
            speed *= -1;
        }
    }
}
