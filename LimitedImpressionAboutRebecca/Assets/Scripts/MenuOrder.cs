using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOrder : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Menuorder(){
        transform.SetSiblingIndex(1);
    }
    public void SayDialogueBack(){
        anim.SetBool("Back",true);
    }
    public void SayDialogueShow(){
        anim.SetBool("Back",false);
    }
}
