using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talking : MonoBehaviour
{public GameObject SayDialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SayDialogue.active==true){
            GetComponent<MoveWASD>().enabled=false;
        }
        else{
            GetComponent<MoveWASD>().enabled=true;
        }

    }
}
