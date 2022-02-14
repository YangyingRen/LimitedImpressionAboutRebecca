using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Talking : MonoBehaviour
{public GameObject SayDialogue,NoteUI,Magnifier,Email;
 public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SayDialogue.active==true){
            GetComponent<MoveWASD>().enabled=false;
            flowchart.SetBooleanVariable("Protagonist",false);

        }
        else{
            GetComponent<MoveWASD>().enabled=true;
            flowchart.SetBooleanVariable("Protagonist",true);

        }
        if(NoteUI.active==true||Magnifier.active==true||Email.active==true){
            GetComponent<MoveWASD>().enabled=false;
            

        }
        else{
            GetComponent<MoveWASD>().enabled=true;
      

        }

    }
}
