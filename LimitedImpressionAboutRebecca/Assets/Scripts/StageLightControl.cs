using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class StageLightControl : MonoBehaviour
{
    public GameObject Light0,Light1,Light2,Light3;
    public Volume m_volume;
    public ClampedFloatParameter Intensity;
    public Vector2Parameter[] Center;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }
    public void GameStart(){
        
        StartCoroutine(Light0On());
    }
    IEnumerator Light0On(){
    yield return new WaitForSeconds(1.5f);
    Light0.SetActive(true);
    }
    IEnumerator Light1On(){
    yield return new WaitForSeconds(0.5f);
    Light1.SetActive(true);
    }
    IEnumerator Light2On(){
    yield return new WaitForSeconds(0.1f);
    Light2.SetActive(true);
    }
    IEnumerator Light3On(){
    yield return new WaitForSeconds(0.1f);
    Light3.SetActive(true);
    }

    public void Prologue0Light(){
    StartCoroutine(Light1On());
    }
    public void Prologue1Light(){
    StartCoroutine(Light2On());
    }
    public void Prologue2Light(){
    StartCoroutine(Light3On());
    }

}
