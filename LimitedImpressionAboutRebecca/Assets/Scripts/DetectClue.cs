using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DetectClue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
        if(flowchart.GetBooleanVariable("ClueInteractable")==true){
         Fungus.Flowchart.BroadcastFungusMessage (broadcast); 
        }

    }
    public void Describe(){
      flowchart.SetIntegerVariable("ClueNum",Num); 

      
    }
    public void DescribeOff(){
        flowchart.SetIntegerVariable("ClueNum",0); 
    }
 
}
