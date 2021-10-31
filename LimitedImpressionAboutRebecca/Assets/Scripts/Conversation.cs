using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    public GameObject Icon;
    public bool isActive;
    private float i=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Icon.GetComponent<SpriteRenderer>().color=new Color(1,1,1,i);

    if(isActive==true){
        Icon.SetActive(true);
        if(i<=1){
        i+=2*Time.deltaTime;}
        else{
            i=1;
        }
    }
    else{
        if(i>0){
        i-=2*Time.deltaTime;}
        else{
            i=0;
            Icon.SetActive(false);
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
