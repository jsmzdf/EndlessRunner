using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.z;
        if(Input.GetKey(KeyCode.A) ){
            
            transform.Translate(0,0,Time.deltaTime+1);
            
        }
         if(Input.GetKey(KeyCode.D) ){
            
            transform.Translate(0,0,Time.deltaTime-1);

        }
             Debug.Log(x);
        
        
    }
}
