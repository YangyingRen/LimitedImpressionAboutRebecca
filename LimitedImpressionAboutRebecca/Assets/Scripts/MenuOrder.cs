using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        GetComponent<Image>().color=new Color(0,0,0,0);
    }
    public void SayDialogueShow(){
        anim.SetBool("Back",false);
    }
    public void Highlighted(){
        GetComponent<Image>().color=new Color(1,1,1,1);
    }
    public void PointExited(){
        GetComponent<Image>().color=new Color(0,0,0,0);

    }
}
