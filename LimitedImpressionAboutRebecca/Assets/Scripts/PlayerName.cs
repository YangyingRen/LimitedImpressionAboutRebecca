using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class PlayerName : MonoBehaviour
{
    public GameObject Name,InputName;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
       GameObject Input= Instantiate(InputName,parent);
        Name.GetComponent<Character>().nameText=Input.GetComponent<Text>().text;
        
    }

    // Update is called once per frame
    void Update()
    {
    }

}
