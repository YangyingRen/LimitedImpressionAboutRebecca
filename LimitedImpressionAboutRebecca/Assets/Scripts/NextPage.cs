using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextPage : MonoBehaviour
{
    public GameObject[] Pages;
    private int i=0, len;
    // Start is called before the first frame update
    void Start()
    {
        len=Pages.Length;
    }

    // Update is called once per frame
    void Update()
    {  for(int j=0;j<len;j++){
        if(j==i){
        Pages[j].SetActive(true);}
        else{
        Pages[j].SetActive(false);
        Pages[j].transform.localPosition=new Vector3(0,0,1);}
        }
        }
    
    public void Next(){
        if(i==len-1){
            i=0;
        }
        else{
        i+=1;
        } 
    }
}
