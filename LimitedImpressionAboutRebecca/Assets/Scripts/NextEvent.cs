using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextEvent : MonoBehaviour
{

    public GameObject Event;
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive==true){
        Event.SetActive(true);
       }
    }

    void  OnTriggerEnter(Collider other ){

        if(other.tag=="Player"){
            isActive=true;

        }    }
}
