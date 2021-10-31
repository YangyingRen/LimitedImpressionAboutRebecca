using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour
{
   public float speed = 1.5f;
     public Vector3 target;
 
     void Start () {
         target = transform.position;
     }
     
     void Update () {
    Vector3 acc=Vector3.zero;
    Vector3 diff;
    if(Input .GetKey(KeyCode.A))
    {transform.localScale=new Vector3 (transform.localScale.x*(-1f),transform.localScale.y,transform.localScale.z);
    acc.x=speed*(-1f);
    }
    if(Input .GetKey(KeyCode.D))
    {transform.localScale=new Vector3 (transform.localScale.x*(-1f),transform.localScale.y,transform.localScale.z);
    acc.x=speed;
    }
    diff=Vector3.MoveTowards(transform.localPosition,transform.localPosition+acc,1f*Time.time);
    transform.localPosition=diff;

     }    
}
