using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointCounter;
    public bool win = false;
    public TMP_Text winText;

    private void Start()
    {
        winText.text = ("");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointCounter.triggeredCheckpoints == checkpointCounter.numberOfCheckpoints)
            {
                winText.text = ("You Win");
                win = true;
                Invoke("reloadScene", 7);
            }
            else
            {
                winText.text = ("Cheater");
                Invoke("reloadScene", 7);
            }
        }
    }

    private void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
