using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_myExScript : MonoBehaviour
{

    public int Age = 0;

    // Start is called before the first frame update
    public void Awake()
    {
        Age = 12;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void m_PrintBla()
    {
        print("foo");
    }
}
