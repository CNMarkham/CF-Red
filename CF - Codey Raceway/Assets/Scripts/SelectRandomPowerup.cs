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
        if (Input.GetKeyUp("space"))
        {
            GameObject powerup = Instantiate(chosenPowerup, new Vector3(transform.position.x+1, transform.position.y+1, transform.position.z+1), transform.rotation);
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
