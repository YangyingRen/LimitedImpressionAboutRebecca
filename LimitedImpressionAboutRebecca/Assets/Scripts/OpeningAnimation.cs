using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class OpeningAnimation : MonoBehaviour
{
    public Text prologue1, prologue2, Title,Name;
    public string text1,text2;
    public Animator anim1;
    public GameObject StartButton,namePrefab, Panel;
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
    if(prologue1.gameObject.active==true){
    if(text1==prologue1.text){
        prologue1Finish();
    }}
    if(text2==prologue2.text){
        Panel.SetActive(true);
        prologue2.transform.parent=transform;
        anim1.SetBool("Finished",true);
    }
        
    }

    public void GameStart(){
        Time.timeScale=1;
    }

    public void prologueStart(){
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
        prologue1.gameObject.SetActive(true);
        
    }
    
    public void SaveName(){
      namePrefab.GetComponent<Text>().text=Name.text;
      
    }
}
