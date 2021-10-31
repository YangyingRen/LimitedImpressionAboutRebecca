using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhoneUI : MonoBehaviour
{
   public GameObject ContactPanel, PCPanel, CluePanel, ItemPanel,ConfirmPanel, TurnOff, TurnOffPanel;
   public Transform Player;
   public Button[] Contact;
   public GameObject[] Conversation;
   public GameObject[] Return;
   private int len;
   private int i=0;
    
    // Start is called before the first frame update
    void Start()
    {
      len=Conversation.Length;
        
    }

    // Update is called once per frame
    void Update()
    {   
     Player.GetComponent<MoveWASD>().enabled=false;
     float scroll=TurnOff.GetComponent<Scrollbar>().value;   
     if(scroll>0.99){
       Fungus.Flowchart.BroadcastFungusMessage ("TurnOff");
     }    
    }

    public void ContactOpen(){
      ContactPanel.SetActive(true);
    }
    public void ContactClose(){
      ContactPanel.SetActive(false);
      }
    public void SelectConversation1(){
      Conversation[0].SetActive(true);
    }
    public void CloseConversation1(){
      Conversation[0].SetActive(false);
    }
    public void SelectClue(){
      CluePanel.SetActive(true);
      ItemPanel.SetActive(false);
    }
    public void CloseClue(){
      CluePanel.SetActive(false);
    }
     public void SelectItem(){
      CluePanel.SetActive(false);
      ItemPanel.SetActive(true);
    }
    public void CloseItem(){
      ItemPanel.SetActive(false);
    }

    public void SelectPC(){
      PCPanel.SetActive(true);
    }
    public void ClosePC(){
      PCPanel.SetActive(false);
    }
    public void SelectTurnOff(){
      TurnOffPanel.SetActive(true);
    }
    public void CloseTurnOff(){
      TurnOffPanel.SetActive(false);
    }
    public void Confirm(){
      ConfirmPanel.SetActive(false);
    }
    public void ConfirmItem(){
      ConfirmPanel.SetActive(true);
    }
    
}