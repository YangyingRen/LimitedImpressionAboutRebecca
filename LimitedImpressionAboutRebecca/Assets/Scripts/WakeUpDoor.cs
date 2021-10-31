using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUpDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position==new Vector3(0,0,0)){

            gameObject.GetComponent<Animator>().enabled=true;
            
        }

        
    }
}
