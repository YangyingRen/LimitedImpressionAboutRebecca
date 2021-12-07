using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class CountTime : MonoBehaviour
{
    public int Time;
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flowchart=GameObject.FindWithTag("Flowchart").GetComponent<Flowchart>();
        Time=flowchart.GetIntegerVariable("Time");
        int hour=10+(int)Mathf.Floor(Time/60);
        int minutes=Time%60;
        if(minutes>=10){

        gameObject.GetComponent<Text>().text=hour.ToString()+":"+minutes.ToString();
        }
        else{
        gameObject.GetComponent<Text>().text=hour.ToString()+":0"+minutes.ToString();
        }
    }
}
