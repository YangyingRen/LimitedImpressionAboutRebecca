using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WritingNotes : MonoBehaviour
{
    public Text typing, wordcount,notes;
    public Transform notespad;
    public Button SendNotes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    int words=typing.text.Length;
    wordcount.text=words.ToString();
    if(words>=50){
        SendNotes.interactable=false;
    }
    else{
        SendNotes.interactable=true;
    }
        
    }

    public void Send(){
        GameObject NewNotes=Instantiate(notes.gameObject,notespad);
        NewNotes.GetComponent<Text>().text=typing.text;
    }

}
