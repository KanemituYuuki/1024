using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;//TextMeshProŽg‚¤‚Ì‚É•K{

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public float totalTime;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(totalTime>=0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                totalTime -= 1;
            }
        }

        //if(Time.deltaTime<=10)
        //{

        //}

        totalTime += Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();
    }
}
