using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class InteractItemPrevious : MonoBehaviour
{

    public Material Default, Select;
    public GameObject PreviousPP;
    public GameObject[] InteractiveItems;
    public int i,len;
    // Start is called before the first frame update
    void Start()
    {
    len=InteractiveItems.Length;
    i=0;
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKey(KeyCode.Tab)){
        PreviousPP.SetActive(true);
        for(i=0;i<len;i++){
            InteractiveItems[i].GetComponent<SpriteRenderer>().material=Select;
            InteractiveItems[i].GetComponent<Light2D>().enabled=true;
        }

    }
    else{
        PreviousPP.SetActive(false);
        for(i=0;i<len;i++){
            InteractiveItems[i].GetComponent<SpriteRenderer>().material=Default;
            InteractiveItems[i].GetComponent<Light2D>().enabled=false;
        }

    }
    
        
    }
}
