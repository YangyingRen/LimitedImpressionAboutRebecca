using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroySameObject : MonoBehaviour
{
    private int len,i,j;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
    len=transform.childCount;
    for(i=0;i<len;i++){
        for(j=i+1;j<len;j++){
            if(transform.GetChild(i).name==transform.GetChild(j).name){
                Destroy(transform.GetChild(j).gameObject);
            }
        }
    }
    }

}
