using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLength : MonoBehaviour
{public bool isActive;
public GameObject camera;
public Vector3 Distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive==true){
            camera.GetComponent<CameraFollow>().enabled=true;
            camera.GetComponent<CameraFollow>().offset=Distance;
        }
        else{
            camera.GetComponent<CameraFollow>().enabled=false;
 
        }
        
    }
    private void OnTriggerStay(Collider col){
        if(col.tag=="Player"){
            isActive=true;
        }
    }
    private void OnTriggerExit(Collider col){
        if(col.tag=="Player"){
            isActive=false;
        }
    }
}
