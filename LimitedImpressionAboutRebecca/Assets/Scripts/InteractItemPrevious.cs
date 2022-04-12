using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;
using Fungus;

public class InteractItemPrevious : MonoBehaviour
{

    public Material Default, Select;
    public GameObject PreviousPP, Guide, SayDialogue;
    public GameObject[] InteractiveItems, DragItems;
    public int i,j,len,lenDrag;
    public Text Quest,Hint;
    // Start is called before the first frame update
    void Start()
    {
    len=InteractiveItems.Length;
    lenDrag=DragItems.Length;
    i=0;
    j=0;
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKey(KeyCode.Tab)){
        Guide.SetActive(false);
        PreviousPP.SetActive(true);
        for(i=0;i<len;i++){
            if(InteractiveItems[i].GetComponent<Clickable2D>().clickEnabled==true){
            InteractiveItems[i].GetComponent<SpriteRenderer>().material=Select;
            InteractiveItems[i].GetComponent<Light2D>().enabled=true;
        }
        }

    }
    else{
        PreviousPP.SetActive(false);
        for(i=0;i<len;i++){
            InteractiveItems[i].GetComponent<SpriteRenderer>().material=Default;
            InteractiveItems[i].GetComponent<Light2D>().enabled=false;
        }

    }
    if(Input.GetKey(KeyCode.Q)){
         Hint.gameObject.SetActive(true);
         Hint.text=Quest.text;  
        }
    else{
         Hint.gameObject.SetActive(false);
    }
    if(SayDialogue.active==true){
        for(i=0;i<len;i++){
            InteractiveItems[i].GetComponent<Clickable2D>().clickEnabled=false;
        }
        for(j=0;j<lenDrag;j++){
            DragItems[j].GetComponent<Draggable2D>().enabled=false;
        }
    }
    else{
        for(i=0;i<len;i++){
            InteractiveItems[i].GetComponent<Clickable2D>().clickEnabled=true;
    }
        for(j=0;j<lenDrag;j++){
            DragItems[j].GetComponent<Draggable2D>().enabled=true;
        }
    }
    
        
    }
}
