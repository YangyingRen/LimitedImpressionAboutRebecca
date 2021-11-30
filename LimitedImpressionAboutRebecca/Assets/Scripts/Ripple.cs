using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ripple : MonoBehaviour
{

    public GameObject Ripples;
    public ParticleSystem Rain;
    public List<ParticleCollisionEvent> collisionEvents;
    // Start is called before the first frame update
    void Start()
    {
      Rain=GetComponent<ParticleSystem>();
      collisionEvents=new List<ParticleCollisionEvent>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnParticleCollision(GameObject rain){
            
            Debug.Log("");
            
            Instantiate(Ripples,transform);
            float x=Random.Range(-0.5f,0.5f);
            float y=Random.Range(-0.5f,0.5f);
            Ripples.transform.position=new Vector3(x,y,0);
        }
    }

