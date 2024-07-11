using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer_stage2 : MonoBehaviour
{
    public UnityEngine.UI.Text text_Timer;
    private float time_start;
    private float time_current;
    private float time_Max = 30f;
    private bool isEnded;

    private void Start()
    {
        Reset_Timer();
    }
    void Update()
    {
        if (isEnded)
            return;

        Check_Timer();
    }

    private void Check_Timer()
    {
        time_current = Time.time - time_start;
        if (time_current < time_Max)
        {
            text_Timer.text = $"{time_current:N2}";
        }
        else if (!isEnded)
        {
            End_Timer();
        }
    }

    private void End_Timer()
    {
        time_current = time_Max;
        text_Timer.text = $"{time_current:N2}";
        isEnded = true;

        SceneManager.LoadScene("finally");
    }


    private void Reset_Timer()
    {
        time_start = Time.time;
        time_current = 0;
        text_Timer.text = $"{time_current:N2}";
        isEnded = false;
    }


}