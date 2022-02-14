using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class KeyInfor : MonoBehaviour
{
    private int KeyInformation, KeyAmount;
    public Flowchart flowchart;
    private Image image;
    public float minimum;
    public GameObject KeyComplete;

    // Start is called before the first frame update
    void Start()
    {
    image=GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update()
    {minimum=image.fillAmount;
    KeyInformation=flowchart.GetIntegerVariable("KeyInfo");
    KeyAmount=flowchart.GetIntegerVariable("KeyAmount");
    image.fillAmount=Mathf.Lerp(minimum,(float)KeyInformation/(float)KeyAmount,Time.deltaTime);   
    if(minimum>0.99){
        KeyComplete.GetComponent<Text>().text="KEY INFORMATION COMPLETED";
    }  
    else {
        KeyComplete.GetComponent<Text>().text="ANALYZING";
    }
    }
}
