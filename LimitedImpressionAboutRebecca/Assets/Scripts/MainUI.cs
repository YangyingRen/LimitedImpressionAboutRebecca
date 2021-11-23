using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public GameObject ItemPanel, CluePanel, PhonePanel;
    private int i,c,p;
    // Start is called before the first frame update
    void Start()
    {
        i=0;
        c=0;
        p=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckItem(){

        if(i==0){
            ItemPanel.SetActive(true);
            i=1;
        }
        else{
            ItemPanel.SetActive(false);
            i=0;
        }
    }
    public void CheckClue(){

        if(c==0){
            CluePanel.SetActive(true);
            c=1;
        }
        else{
            CluePanel.SetActive(false);
            c=0;
        }
    }

    
}
