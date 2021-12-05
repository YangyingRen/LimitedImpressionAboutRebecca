using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public GameObject ItemPanel, CluePanel, PhonePanel, Testimony, Character,Guide;
    public Image testimony,character;
    public Color Selected, Default;
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
        if(ItemPanel.active==false){
            i=0;
        }
        if(CluePanel.active==false){
            c=0;
        }
        
    }

    public void CheckItem(){

        if(i==0){
            ItemPanel.SetActive(true);
            Guide.SetActive(false);
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
            Guide.SetActive(false);

            c=1;
        }
        else{
            CluePanel.SetActive(false);
            c=0;
        }
    }

    public void CheckTestimony(){
        Testimony.SetActive(true);
        Character.SetActive(false);
        testimony.color=Selected;
        character.color=Default;

    }

    public void CheckCharacter(){
        Testimony.SetActive(false);
        Character.SetActive(true);
        testimony.color=Default;
        character.color=Selected;
    }

    
}
