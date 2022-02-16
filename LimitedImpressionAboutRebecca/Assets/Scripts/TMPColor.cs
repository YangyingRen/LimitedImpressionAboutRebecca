using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMPColor : MonoBehaviour
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
        
    }

    private void OnTriggerEnter(Collider col){
          if(col.tag=="Player"){
              anim.SetBool("InTrigger",true);

          }
    }
    private void OnTriggerExit(Collider col){
          if(col.tag=="Player"){
              anim.SetBool("InTrigger",false);

          }
    }
}
