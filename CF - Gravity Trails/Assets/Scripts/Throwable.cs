using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Throwable : MonoBehaviour
{

    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public Text collectableCounter;

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
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(objectThrown, throwablePosition, transform.rotation);
            throwableCounter -= 1;
            collectableCounter.text = throwableCounter.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Collectable"))
        {
            throwableCounter += 1;
            collectableCounter.text = throwableCounter.ToString();
            Destroy(collision.gameObject);
        }
    }
}
