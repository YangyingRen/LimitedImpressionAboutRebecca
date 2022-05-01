using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            anim.SetBool("Run",true);
            GetComponent<MoveWASD>().speed=0.05f;
        }
        else{
            anim.SetBool("Run",false);
            GetComponent<MoveWASD>().speed=0.03f;

        }
        
    }
}
