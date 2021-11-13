using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class CountMoney : MonoBehaviour
{
    public int Money;
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   flowchart=GameObject.FindWithTag("Flowchart").GetComponent<Flowchart>();
        Money=flowchart.GetIntegerVariable("Money");
        gameObject.GetComponent<Text>().text="Cash: $"+Money.ToString();
    }
}
