using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimation : MonoBehaviour
{
    public GameObject RainDrop ;
    private Vector3 lastPos;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<lastPos.x){
           transform.localScale=new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
           anim.SetBool("Walk",true);
        }
        else if(transform.position.x>lastPos.x){
           transform.localScale=new Vector3(Mathf.Abs(transform.localScale.x)*(-1f),transform.localScale.y,transform.localScale.z);
           anim.SetBool("Walk",true);
        }
        else{
                        anim.SetBool("Walk",false);
        }

        lastPos=transform.position;
        
        
    }
}
