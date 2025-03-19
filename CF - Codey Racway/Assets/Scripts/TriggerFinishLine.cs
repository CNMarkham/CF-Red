using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointCounter;
    public bool win = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointCounter.triggeredCheckpoints == checkpointCounter.numberOfCheckpoints)
            {
                print("You Win");
                win = true;
                SceneManager.LoadScene(0);
            }
            else
            {
                print("Cheater");
            }
        }
    }
}
