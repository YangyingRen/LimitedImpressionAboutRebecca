using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if(Input .GetKeyDown(KeyCode.A))
    {transform.localScale=new Vector3 (transform.localScale.x*(-1f),transform.localScale.y,transform.localScale.z);
    }
    if(Input .GetKeyDown(KeyCode.D))
    {transform.localScale=new Vector3 (transform.localScale.x,transform.localScale.y,transform.localScale.z);
    }
        
    }
}
