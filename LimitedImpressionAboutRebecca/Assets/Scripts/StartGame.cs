using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartGame : MonoBehaviour
{
    public Text Sign,Name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void prologue2Finished(){

         SceneManager.LoadScene("SecondDemo");
    }

    public void Signature(){
    Sign.text=Name.text;
    Sign.gameObject.SetActive(true);
    GetComponent<AudioSource>().Stop();
    }
}
