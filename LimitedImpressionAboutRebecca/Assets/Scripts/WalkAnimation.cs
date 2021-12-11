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
        if(transform.position.x<lastPos.x){
           GameObject Drop= Instantiate(RainDrop,transform);
           RainDrop.transform.position=new Vector3(0,-0.8f,0);
        }
        else if(transform.position.x>lastPos.x){
          GameObject Drop= Instantiate(RainDrop,transform);
          RainDrop.transform.position=new Vector3(0,-0.8f,0); 
        }
        lastPos=transform.position;
        
        
    }
}
