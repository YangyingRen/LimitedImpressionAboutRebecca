using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastChatPhrase : MonoBehaviour
{

    public GameObject Content;
    public int i;
    public int max;
    // Start is called before the first frame update
    void Start()
    {
        i=0;
        
    }

    // Update is called once per frame
    void Update()
    {   int len=Content.transform.childCount;
        for(i=0;i<len;i++){
        if(!Content.transform.GetChild(i).gameObject.activeSelf){
        Transform lastChild=Content.transform.GetChild(i-1);
        Transform lastText=lastChild.Find("StoryText");
        gameObject.GetComponent<Text>().text=lastText.GetComponent<Text>().text;
        if(i>max){
            Destroy(Content.transform.GetChild(1).gameObject);
        }
            break;
            }
        }
        
        
    }
}
