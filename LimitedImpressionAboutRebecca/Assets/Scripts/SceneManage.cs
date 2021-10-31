using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage : MonoBehaviour
{
    public bool isActive;
    public GameObject SwitchTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive=true){
            gameObject.GetComponent<SelectManager>().enabled=true;
            SwitchTrigger.SetActive(false);
        }
        else{
            gameObject.GetComponent<SelectManager>().enabled=false;
            SwitchTrigger.SetActive(true);

        }
        
    }
    void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            isActive=true;
        }

    }
     void OnTriggerExit(Collider other){
        if(other.tag=="Player"){
            isActive=false;
        }
}
}
