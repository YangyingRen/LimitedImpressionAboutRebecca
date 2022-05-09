using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public GameObject ItemPanel, CluePanel, PhonePanel, Testimony, Character,Guide, Email, EmailIcon, Magnifier, MagCamera, Transcript;
    public Image testimony,character;
    public Color Selected, Default;
    private int i,c,p;
    public Texture2D hoverCursor;
    public AudioSource[] OST;
   
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
        if(Magnifier.active==true){
            OST[1].volume+=Time.deltaTime;
        }
        else{
            OST[1].volume-=Time.deltaTime;
        }
        
        
    }

    public void CheckItem(){

        CluePanel.SetActive(false);

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
        ItemPanel.SetActive(false);

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
    public void ChangeCursor(Texture2D cursorTexture)
        {

            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        }
    public void Clicked(Texture2D cursorTexture){
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    public void OpenEmail(){
        Email.SetActive(true);
        EmailIcon.SetActive(false);
        
    }
    public void CloseEmail(){
            Email.SetActive(false);
    }
    public void CloseTranscript(){
            Transcript.SetActive(false);
    }
    public void CloseMagnifier(){
            Magnifier.SetActive(false);
            GameObject.Find("StartTalkingPP").SetActive(false);
            int MagLen=MagCamera.transform.childCount;
            for(int j=0;j<MagLen;j++){
                MagCamera.transform.GetChild(j).gameObject.SetActive(false);            }
    }

    
}
