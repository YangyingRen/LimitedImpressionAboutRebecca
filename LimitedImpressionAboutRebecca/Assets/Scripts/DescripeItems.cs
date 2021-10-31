using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescripeItems : MonoBehaviour
{
   
    public string Description;
    public GameObject DescriptionPanel;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Describe(){
      DescriptionPanel=GameObject.FindWithTag("Description");
      DescriptionPanel.GetComponent<Text>().text=Description;
      
    }
    public void DescribeOff(){
        DescriptionPanel.GetComponent<Text>().text="";

    }
}
