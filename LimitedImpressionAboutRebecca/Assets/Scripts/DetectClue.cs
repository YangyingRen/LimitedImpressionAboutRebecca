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

    public void Trigger(){
        if(flowchart.GetBooleanVariable("Interactable")==true){
         Fungus.Flowchart.BroadcastFungusMessage (broadcast); 
        }

    }
 
}
