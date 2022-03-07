using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conclusion : MonoBehaviour
{
    public Text conclusion, Murderer;
    public Transform Reason;
    public string[] reasons;
    public GameObject ConclusionPage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    conclusion.text="Base on what I know, I assume the murderer is"+Murderer.text+". Because ";
    int len=Reason.childCount;
    for(int i=0;i<len-1;i++){
        reasons[i]=Reason.GetChild(i).gameObject.GetComponent<Text>().text;
        conclusion.text=conclusion.text+". "+reasons[i];
    }
    }
    
        
    

    public void Submit(){
        gameObject.SetActive(false);
        ConclusionPage.SetActive(true);
        
}
}
