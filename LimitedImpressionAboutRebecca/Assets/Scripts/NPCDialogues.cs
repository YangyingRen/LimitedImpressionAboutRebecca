using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCDialogues : MonoBehaviour
{
    public string[] Dialogues;
    public string text;
    private float alpha,time;
    private int len,i;
    private Color color;
    // Start is called before the first frame update
    void Start()
    {
      alpha=0;
      len=Dialogues.Length;
      time=0;
      
    }

    // Update is called once per frame
    void Update()
    {  text=Dialogues[i];
       GetComponent<TextMeshPro>().text=text;
        if(time<1){
        time+=Time.deltaTime*0.5f;
    }
    else{
        time=0;
        if(i<len-1){
            i+=1;
        }
        else{
            i=0;
        }
    }
    
    
    }

    }

