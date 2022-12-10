using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransformSir : MonoBehaviour
{
    Vector3 g_MoveDirection = Vector3.zero;
    Vector3 g_RotateDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_Move();
        m_Rotate();
        m_Scale();
    }

    void m_Move()
    {
        g_MoveDirection.x = Input.GetAxis("Horizontal");
        g_MoveDirection.z = Input.GetAxis("Vertical");
        this.transform.Translate(g_MoveDirection * Time.deltaTime * 5);
    }

    void m_Rotate()
    {
        g_RotateDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            g_RotateDirection = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            g_RotateDirection = Vector3.down;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            g_RotateDirection = Vector3.right;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            g_RotateDirection = Vector3.left;
        }

        this.transform.Rotate(g_RotateDirection * Time.deltaTime * 30);

    }

    void m_Scale()
    {
        g_RotateDirection = Vector3.zero;

        if (this.transform.localScale.x < 5)
        {
            if (Input.GetKey(KeyCode.O))
            {
                this.transform.localScale += Vector3.one * Time.deltaTime * 3;
            }
        }
        if (this.transform.localScale.x > 1)
        {
            if (Input.GetKey(KeyCode.I))
            {
                this.transform.localScale -= Vector3.one * Time.deltaTime * 3;
            }
        }

    }

  }

