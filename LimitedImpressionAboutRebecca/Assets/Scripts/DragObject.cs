using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class DragObject : MonoBehaviour
{
    public Transform[] DragGameObjects;
    private int i,len;
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
    len=DragGameObjects.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
    for(i=0;i<len;i++){
        if(DragGameObjects[i].gameObject.active==true){
        flowchart.SetIntegerVariable("ObjectNum", i+1);
        }

    }
    }
}
