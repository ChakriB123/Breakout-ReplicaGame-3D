using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_SphereMove : MonoBehaviour
{
    float g_ElapsedTime = 0;
    float g_StartTime = 0;
    float g_TargetTime = 0;
    int g_MoveCounter = 0;

    Vector3 g_MoveDirection = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        g_ElapsedTime = 0;
        g_StartTime = Time.time;
        g_TargetTime = 15;
        g_MoveCounter = 1;
        g_MoveDirection = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        m_ManageMovement();
    }

    void m_ManageMovement()
    {
        g_ElapsedTime = Time.time - g_StartTime;

        Debug.Log(g_ElapsedTime);
        if (g_ElapsedTime >= g_TargetTime)
        {
            g_ElapsedTime = 0;
            g_StartTime = Time.time ;

            g_MoveCounter++;

            if (g_MoveCounter == 1)
            {
                g_MoveDirection = Vector3.right;
                g_ElapsedTime = 10;
            }
            else if (g_MoveCounter == 2)
            {
                g_MoveDirection = Vector3.zero;
                g_ElapsedTime = 10;
            }
            else if (g_MoveCounter == 3)
            {
                g_MoveDirection = Vector3.left;
                g_ElapsedTime = 10;
            }
            else if (g_MoveCounter == 4)
            {
                g_MoveDirection = Vector3.zero;
                g_ElapsedTime = 10;
                g_MoveCounter = 0;
            }

        }

        this.transform.Translate(g_MoveDirection * Time.deltaTime);
    }
}
