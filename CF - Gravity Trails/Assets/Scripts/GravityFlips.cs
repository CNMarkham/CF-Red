using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlips : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRigidbody.gravityScale *= -1;
            Vector3 newDirection = transform.localScale;
            newDirection.y *= -1;
            transform.localScale = newDirection;
        }
    }
}
