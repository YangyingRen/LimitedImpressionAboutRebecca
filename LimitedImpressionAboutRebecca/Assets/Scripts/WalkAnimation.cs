using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimation : MonoBehaviour
{
    public GameObject RainDrop ;
    private Vector3 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<=lastPos.x){
           transform.localScale=new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
        }
        else if(transform.position.x>lastPos.x){
           transform.localScale=new Vector3(Mathf.Abs(transform.localScale.x)*(-1f),transform.localScale.y,transform.localScale.z);
        }
        lastPos=transform.position;
        
        
    }
}
