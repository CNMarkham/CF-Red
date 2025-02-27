using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointCounter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointCounter.triggeredCheckpoints == checkpointCounter.numberOfCheckpoints)
            {
                Debug.Log("You Win");
            }
            else
            {
                Debug.Log("Cheater");
            }
        }
    }
}
