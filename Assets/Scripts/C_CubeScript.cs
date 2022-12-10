using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_CubeScript : MonoBehaviour
{
    public C_myExScript myExScriptComp;
    
    // Start is called before the first frame update
    void Awake()
    {
        myExScriptComp = this.gameObject.AddComponent<C_myExScript>();        
    }
    void Start()
    {
        print(myExScriptComp.Age);
        myExScriptComp.m_PrintBla();
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
