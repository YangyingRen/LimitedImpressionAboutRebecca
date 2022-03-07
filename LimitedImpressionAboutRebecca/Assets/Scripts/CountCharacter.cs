using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class CountCharacter : MonoBehaviour
{
    [SerializeField]
    public Transform Character;
    private Dropdown m_Dropdown;
    public string[] options;
    public Text MurdereName;
    
    // Start is called before the first frame update
    void Start()
    {
    m_Dropdown=GetComponent<Dropdown>();
    m_Dropdown.ClearOptions();
    
    }

    // Update is called once per frame
    void Update()
    {
    for(int i=0;i<Character.childCount;i++){
    options[i+1]=Character.GetChild(i).GetChild(2).gameObject.GetComponent<Text>().text;

    }
    AddDropdownOptions(m_Dropdown,options);
    m_Dropdown.onValueChanged.AddListener(delegate {Select(m_Dropdown);});
    

   
    

    }

    void AddDropdownOptions(Dropdown m_Dropdown, string[] options){
        List<string> optionsList=new List<string>(options);
        m_Dropdown.ClearOptions();
        m_Dropdown.AddOptions(optionsList);

    }
    public void Select(Dropdown m_Dropdown){
        int index= m_Dropdown.value;
        MurdereName.text=m_Dropdown.options[index].text;
       

    }

}
