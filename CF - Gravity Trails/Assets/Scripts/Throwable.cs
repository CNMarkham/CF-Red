using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{

    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;


    // Start is called before the first frame update
    void Start()
    {
        throwableCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwableCounter >= 1)
        {
            Debug.Log("fire");
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(objectThrown, throwablePosition, transform.rotation);
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            throwableCounter -= 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Collectables"))
        {
            throwableCounter += 1;
            Destroy(collision.gameObject);
        }
    }
}
