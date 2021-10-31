using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStage : MonoBehaviour
{

    public bool isActive;
    public Animator SwitchPlayer;
    public Animator SwitchPanel;
    public Transform NextDoor;
    public Transform currentScene;
    public Transform Player;
    public float i=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(isActive==true){
            if(transform==currentScene.GetComponent<SelectManager>().selection){
            if(Input.GetMouseButtonDown(0)){
            SwitchPlayer.SetBool("Switch",true);
            SwitchPanel.SetBool("Switch",true);

            }}
            if(Player.GetComponent<SpriteRenderer>().color.a<0.05f){
            NextDoor.GetComponent<SwitchStage>().enabled=false;
            Player.position=new Vector3(NextDoor.position.x,Player.position.y,Player.position.z);
            SwitchPlayer.SetBool("Switch",false);
            SwitchPanel.SetBool("Switch",false);

            }
            
            
 
            } 
        if(Player.GetComponent<SpriteRenderer>().color.a<0.99f){
           Player.GetComponent<MoveWASD>().enabled=false;
        }  
        else{
            Player.GetComponent<MoveWASD>().enabled=true;

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

