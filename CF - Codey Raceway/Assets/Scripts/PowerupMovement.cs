using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupMovement : MonoBehaviour
{
    public GameObject CodeyMove;
    public float speed;

    void Start()
    {
        speed = CodeyMove.GetComponent<CodeyMove>().Speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("obstacles"))
        {
            Destroy(collision.gameObject);
            Destroy(transform.gameObject);
        }
    }
}
