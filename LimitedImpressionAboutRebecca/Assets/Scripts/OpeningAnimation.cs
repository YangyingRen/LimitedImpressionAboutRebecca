using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpeningAnimation : MonoBehaviour
{
    public Text prologue1, prologue2;
    public string text1,text2;
    public Animator anim;
    public GameObject StartButton;
    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale=0; 
    }

    // Update is called once per frame
    void Update()
    {
    if(text1==prologue1.text){
        prologue1Finish();
    }
    if(text2==prologue2.text){
        anim.SetBool("Finish1",true);
    }
        
    }

    public void GameStart(){
        Time.timeScale=1;
        StartButton.SetActive(false);
    }

    public void prologueStart(){
     prologue1.gameObject.SetActive(true);
    }

    public void prologue1Finish(){
    prologue2.gameObject.SetActive(true);
    text2="	Anyway, this “ Rashomon ” is worthwhile to be known by everyone.";
    }

    public void prologue2Finished(){

         SceneManager.LoadScene("SecondDemo");
    }

    public void Open(){
        int len=transform.childCount;
        transform.GetChild(len-1).SetSiblingIndex(0);
    }

}
