using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   public float speed = 1.5f;
     public Vector3 target;
     public Camera camera;
     public Transform Stage;
 
     void Start () {
         target = transform.position;
     }
     
     void Update () {
         if (Input.GetMouseButtonDown(0)) {
             target=new Vector3(Input.mousePosition.x,Input.mousePosition.y,(Stage.position.z-camera.transform.position.z));
             target = Camera.main.ScreenToWorldPoint(target);
             Debug.Log(target);
             target.z = transform.position.z;
             target.y= transform.position.y;
         }
         transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
     }    
}
