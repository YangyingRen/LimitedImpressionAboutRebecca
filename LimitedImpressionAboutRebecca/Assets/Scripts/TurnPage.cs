using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TurnPage : MonoBehaviour
{
    public Transform Left, Right;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
     anim=gameObject.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TurnRight(){
    anim.SetBool("TurnRight",true);
    anim.SetBool("TurnLeft",false);
    StartCoroutine(Wait());
    transform.SetParent(Right);
    
    }
    public void Turn(){
    Transform front=transform.GetChild(0);
    front.SetAsLastSibling();
    }

    public void TurnLeft(){
    anim.SetBool("TurnRight",false);
    anim.SetBool("TurnLeft",true);
    StartCoroutine(Wait());
    transform.SetParent(Left);
    }
    public void StopTurn(){
    anim.SetBool("TurnLeft",false);
    anim.SetBool("TurnRight",false);
    }
    IEnumerator Wait(){
        yield return new WaitForSecondsRealtime(3);
    }
}
