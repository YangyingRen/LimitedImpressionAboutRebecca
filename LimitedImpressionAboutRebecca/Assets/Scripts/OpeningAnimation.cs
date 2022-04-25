using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class OpeningAnimation : MonoBehaviour
{
    public Text prologue0,prologue1, prologue2, Title,Name;
    public string text0,text1,text2;
    public Animator anim1;
    public GameObject StartButton,namePrefab, Panel,NextButton0,NextButton1;
    public Transform page;
    private float r,g;
    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale=0; 
    }

    // Update is called once per frame
    void Update()
    {
    if(prologue0.gameObject.active==true){
    if(text0==prologue0.text){
        NextButton0.SetActive(true);
    }
    }
   
    if(prologue1.gameObject.active==true){
    NextButton0.SetActive(false);
    if(text1==prologue1.text){
        NextButton1.SetActive(true);
    }}
    if(prologue2.gameObject.active==true){
    NextButton1.SetActive(false);
    if(text2==prologue2.text){
        Panel.SetActive(true);
        prologue2.transform.parent=transform;
        anim1.SetBool("Finished",true);
    }
        
    }}

    public void GameStart(){
        Time.timeScale=1;
    }

    public void prologueStart(){
     prologue0.gameObject.SetActive(true);
    }
    public void prologue0Finish(){
    prologue1.gameObject.SetActive(true);  
  
    }

    public void prologue1Finish(){
  
    prologue2.gameObject.SetActive(true);
    text2="	Anyway, this “ Rashomon ” story is worthwhile to be known by everyone.";
    }



    public void Open(){
        int len=transform.childCount;
    }
    public void TurnPage(){
        prologue0.gameObject.SetActive(true);
        
    }
    
    public void SaveName(){
      namePrefab.GetComponent<Text>().text=Name.text;
      
    }
}
