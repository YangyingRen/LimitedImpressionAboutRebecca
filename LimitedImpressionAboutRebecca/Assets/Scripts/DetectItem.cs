using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class DetectItem : MonoBehaviour
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
    public string Description;
    public GameObject DescriptionPanel;

    public void Trigger(){
        if(flowchart.GetBooleanVariable("ItemInteractable")==true){
        Fungus.Flowchart.BroadcastFungusMessage (broadcast);
        }

    }
    public void Describe(){
      DescriptionPanel=GameObject.FindWithTag("Description");
      DescriptionPanel.GetComponent<Text>().text=Description;
      flowchart.SetIntegerVariable("ItemNum",Num); 

      
    }
    public void DescribeOff(){
        DescriptionPanel.GetComponent<Text>().text="";
        flowchart.SetIntegerVariable("ItemNum",0); 
    }
 
}
