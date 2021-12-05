using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class CountTime : MonoBehaviour
{
    public string Time;
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flowchart=GameObject.FindWithTag("Flowchart").GetComponent<Flowchart>();
        Time=flowchart.GetStringVariable("Time");
        gameObject.GetComponent<Text>().text=Time;
    }
}
