using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NextEvent : MonoBehaviour
{

    public GameObject[] Event;
    public string BoolName;
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flowchart.GetBooleanVariable(BoolName)==true){
        Debug.Log("1");
        for(int i=0;i<Event.Length;i++){
        Event[i].GetComponent<Clickable2D>().clickEnabled=false;
       }
        }
        else{
          for(int i=0;i<Event.Length;i++){
        Event[i].GetComponent<Clickable2D>().clickEnabled=true;  
        }
    }
    }

}
