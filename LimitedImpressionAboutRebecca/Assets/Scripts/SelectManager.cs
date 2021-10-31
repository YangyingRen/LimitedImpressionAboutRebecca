using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public int test=0;
    public string selectableTag="Door";
    private Transform _selection;
    public Material selectMaterial;
    public Material defaultMaterial;
    public GameObject[] doorlist;
    public Vector3 target;
    public Camera camera;
    public Transform Stage;
    public GameObject NextStage;
    public bool isActive;
    public SpriteRenderer selectionRenderer;
    public Transform selection;
    public GameObject SwitchSceneTrigger;
    public Transform Player;
    public Transform NextDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_selection!=null){
           selectionRenderer=_selection.GetComponent<SpriteRenderer>();
            selectionRenderer.material=defaultMaterial;
            _selection=null;
        }
        target=new Vector3(Input.mousePosition.x,Input.mousePosition.y,(Stage.position.z-camera.transform.position.z));

        var ray=Camera.main.ScreenPointToRay(target);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
              selection = hit.transform;
            if (selection.CompareTag(selectableTag)){
              selectionRenderer=selection.GetComponent<SpriteRenderer>();
            if(selectionRenderer!=null){
                    selectionRenderer.material=selectMaterial;
                    //NextStage.SetActive(true);
                    test+=1;
                    //SwitchSceneTrigger.SetActive(true);
                    //selection.GetComponent<BoxCollider>().enabled=true;               
               }
               
                _selection=selection;
            }
            
            }

        }

        void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            isActive=true;
        }

    }
     void OnTriggerExit(Collider other){
        if(other.tag=="Player"){
            isActive=false;
        }

    }
    }

