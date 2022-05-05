using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    private AudioSource BGM;
    public GameObject Audio;
    private float fadeTime=1, loudTime=0;
    // Start is called before the first frame update
    void Start()
    {
    BGM=Audio.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeDown(){
     if(fadeTime==0){
         BGM.volume=0;
         return;
     }
     StartCoroutine(FadeSound());


    }

    IEnumerator FadeSound(){
        float t=fadeTime;
        while(t>0){
            yield return null;
            t-=Time.deltaTime*0.1f;
            BGM.volume=t/fadeTime;
        }
        yield break;
    }
    IEnumerator LoudSound(){
        yield return new WaitForSeconds(2f);
        float t=loudTime;
        while(t<1){
            yield return null;
            t+=Time.deltaTime;
            BGM.volume=t;
        }
        yield break;
    }


    public void BGM2Start(){
        if(loudTime==1){
        BGM.volume=1;
        return;
        }
        GetComponent<AudioSource>().Play();
        StartCoroutine(LoudSound());
    }


}
