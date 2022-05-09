using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMControl : MonoBehaviour
{    public AudioSource[] OST;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       int len =OST.Length;
    for (int i=0;i<len;i++){
        for(int j=0;j<i;j++){
            if(OST[i].volume>0){
                
                OST[j].volume-=Time.deltaTime;
                }
            
            else{
                OST[0].volume+=Time.deltaTime;
            }
        }
    } 
    }
}
