using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class KeyInformationDetect : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject Confirm;
    public GameObject[] Animation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider col){
    if(col.tag=="Information"){
        foreach (GameObject anim in Animation){
            anim.SetActive(true);
        }
        Confirm.GetComponent<Animator>().enabled=true;
        Confirm.GetComponent<AudioSource>().Play();
    }

    }
    private void OnTriggerExit(Collider col){
    if(col.tag=="Information"){
        flowchart.SetIntegerVariable("Information",0);
        Confirm.GetComponent<AudioSource>().Stop();

        Confirm.GetComponent<Animator>().enabled=false;
        foreach (GameObject anim in Animation){
            anim.SetActive(false);
        }
    }

    }
}
