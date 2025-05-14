using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public TMP_Text lapTime;
    public TMP_Text startCountdown;
    public TMP_Text winText;

    public float totalLapTime;
    public float totalCountdownTime;
    public GameObject CodeyMove;
    public float Speed;
    public bool FinishLine;
    public GameObject Finish;


    private void Start()
    {
        Speed = CodeyMove.GetComponent<CodeyMove>().Speed;
        FinishLine = Finish.GetComponent<TriggerFinishLine>().win;
    }


    // Update is called once per frame
    void Update()
    {
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();   
        
        if(totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            Speed = 0;
        }
        if(totalCountdownTime <= 0)
        {
            startCountdown.text = ("");
            totalLapTime -= Time.deltaTime;
            Speed = 15;
        }
        if(totalLapTime <= 0)
        {
            winText.text = ("Time Is Up");
            SceneManager.LoadScene(0);
      }
    }

}
