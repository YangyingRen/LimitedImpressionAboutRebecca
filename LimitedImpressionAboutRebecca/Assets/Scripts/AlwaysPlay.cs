using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlwaysPlay : MonoBehaviour
{
    static AlwaysPlay _instance;
    public static AlwaysPlay instance{
        get{
            if(_instance==null){
                _instance=FindObjectOfType<AlwaysPlay>();
                DontDestroyOnLoad(_instance.gameObject);
          
            }
            return _instance;
        }
    }
    private void Awake(){
            _instance=this;
            DontDestroyOnLoad(this);
    }
    IEnumerator ShutDown(){
        yield return new WaitForSeconds(2f);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string name=SceneManager.GetActiveScene().name;
        if(name=="SecondDemo"){
        gameObject.GetComponent<AudioSource>().volume-=Time.deltaTime*0.2f;   

        }

        
    }
}
