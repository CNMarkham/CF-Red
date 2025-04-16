using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(100 * Time.deltaTime,100 * Time.deltaTime,100 *  Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        Invoke("itemBoxRespawn", 5);
        gameObject.SetActive(false);
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }

}
