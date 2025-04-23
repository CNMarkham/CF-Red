using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space") && chosenPowerup != null)
        {
            Vector3 spawnPosition = transform.position + (transform.forward * 5);

            GameObject powerup = Instantiate(chosenPowerup, spawnPosition, transform.rotation);
            chosenPowerup = null;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }

}
