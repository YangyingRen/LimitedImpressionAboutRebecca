using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChatApp : MonoBehaviour
{
    public int maxMessages=50;
    public GameObject chatPanel, textObject;
    [SerializeField]
    public List<Message> messageList =new List<Message>();
    public AudioSource ReceiveMessage;
    private int len;
    private int r;
    public GameObject FungusDialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetMouseButtonDown(0)){
            SendMessageToChatAI("");
        }
        
    }
    public void SendMessageToChatAI(string text)
    {
        if(messageList.Count>maxMessages) {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        Message newMessage=new Message();
        newMessage.text=text;

        GameObject newTextAI=Instantiate(textObject, chatPanel.transform);
        Transform newText=newTextAI.transform.Find("StoryText");
        newText.GetComponent<Text>().alignment=TextAnchor.MiddleLeft;
        newText.GetComponent<Text>().text=text;
        //FungusDialogue.GetComponent<Fungus.Command.Say.SetSayDialog>().sayDialog=newTextAI;
        //FungusDialogue.GetComponent<Fungus.SayDialog>().activeSayDialogs=newTextAI;
        //FungusDialogue.GetComponent<Fungus.SayDialog>().writer.targetTextObject=newText.gameObject;
        newMessage.textObject =newText.GetComponent<Text>();
        messageList.Add(newMessage);

    }
    public void SendMessageToChat(string text)
    {

        if(messageList.Count>maxMessages) {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        Message newMessage=new Message();
        newMessage.text=text;

        GameObject newText=Instantiate(textObject, chatPanel.transform);
        newText.GetComponent<Text>().alignment=TextAnchor.UpperRight;
        newText.GetComponent<Text>().text=text;
        newMessage.textObject =newText.GetComponent<Text>();
        messageList.Add(newMessage);

    }

    
}
[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;
}
