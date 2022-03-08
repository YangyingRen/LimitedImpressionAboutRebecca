using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DetectCharacter : MonoBehaviour
{void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flowchart=GameObject.FindWithTag("Flowchart").GetComponent<Flowchart>();
        
    }
 
    [Tooltip("broadcast a message to Fungus, which can start Fungus scripts")]
    public string broadcast;
    public Flowchart flowchart;
    public int Num;

    public void Trigger(){
        if(flowchart.GetBooleanVariable("CharInteractable")==true){
         Fungus.Flowchart.BroadcastFungusMessage (broadcast); 
        }

    }
    public void Describe(){
      flowchart.SetIntegerVariable("CharNum",Num); 

      
    }
    public void DescribeOff(){
        flowchart.SetIntegerVariable("CharNum",0); 
    }
}
