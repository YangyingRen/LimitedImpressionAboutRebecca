using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class KeyInformationDetect : MonoBehaviour
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider col){
    if(col.tag=="Information"){
        flowchart.SetIntegerVariable("Information",0);
    }

    }
}
