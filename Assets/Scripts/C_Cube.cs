using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class C_Cube : MonoBehaviour
{

    // for variables   >>>> protection datatype name

    int g_Rotate = 0;
    float g_Speed = 0.0f;

    Vector3 g_Scale = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        g_Speed = 0.05f;
        g_Rotate = 1;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(g_Speed, 0, 0);
        }

       if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-g_Speed, 0, 0);
        }

       if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, g_Speed, 0);
        }

       if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, -g_Speed, 0);
        }

     // ---------------------------------------------------


        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(g_Rotate, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(-g_Rotate, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(0, g_Rotate, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(0, -g_Rotate, 0);
        }

        if (Input.GetKey(KeyCode.O))
        {
            g_Scale = this.transform.localScale;

            g_Scale.x += 0.1f;
            g_Scale.y += 0.1f;
            g_Scale.z += 0.1f;

            this.transform.localScale = g_Scale;
        }

        if (Input.GetKey(KeyCode.P))
        {
            g_Scale = this.transform.localScale;

            g_Scale.x -= 0.1f;
            g_Scale.y -= 0.1f;
            g_Scale.z -= 0.1f;

            this.transform.localScale = g_Scale;
        }
    }
}
