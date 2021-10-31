using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public bool isActive;
    public GameObject[] Doors;
    private int len;
    // Start is called before the first frame update
    void Start()
    {
        len=Doors.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive==true){
            for(int i=0;i<len;i++){
            Doors[i].GetComponent<SwitchStage>().enabled=true;
            }
        }
        
    }
     void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            isActive=true;
        }

    }

    void OnTriggerExit(Collider other){
        if(other.tag=="Player"){
            isActive=false;
        }

    }
}
