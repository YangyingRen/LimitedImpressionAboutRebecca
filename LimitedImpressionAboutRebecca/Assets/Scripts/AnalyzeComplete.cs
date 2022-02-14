using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class AnalyzeComplete : MonoBehaviour
{
    public GameObject[] KeyInfo;
    public Transform Ongoing,Completed;
    private int i,len;
    public Flowchart flowchart;
    public int checkedInfo;
    // Start is called before the first frame update
    void Start()
    {
     len=KeyInfo.Length;   
    }

    // Update is called once per frame
    void Update()
    {checkedInfo=0;
        for(i=0;i<len;i++){
        if (KeyInfo[i].active==false){
        }
        else{
            checkedInfo+=1;
        }
        flowchart.SetIntegerVariable("KeyInfo",checkedInfo);
    }
    
        
    }
}
