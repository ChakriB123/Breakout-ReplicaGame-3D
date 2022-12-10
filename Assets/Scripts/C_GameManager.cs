using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_GameManager : MonoBehaviour
{
    //int Counter = 0;

    public GameObject g_CubeObject;
    public GameObject g_LightObject;
     Light g_LightComp;
   

    // Start is called before the first frame update
    void Start()
    {
       g_LightComp = g_LightObject.transform.GetComponent<Light>();  
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
           // Counter++;
            g_LightComp.enabled = !g_LightComp.enabled;


       
           
            if(g_CubeObject.activeInHierarchy == true)
            {
                g_CubeObject.SetActive(false);
            }
            else
            {
                g_CubeObject.SetActive(true);   
            }

        }
    }
}
