using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBrickMove : MonoBehaviour
{

    public GameObject PlayerObj;
    int g_Speed;
    Vector3 g_MoveDirection = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        g_Speed = 25;
    }

    // Update is called once per frame
    void Update()
    {
        m_MovePlayer();
    }


    void m_MovePlayer()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (PlayerObj.transform.position.x > -22f)
            {
                g_MoveDirection = Vector3.left;
                PlayerObj.transform.Translate(g_MoveDirection * Time.deltaTime * g_Speed);
            }
        }
       
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (PlayerObj.transform.position.x < 24f)
            {
                g_MoveDirection = Vector3.right;
                PlayerObj.transform.Translate(g_MoveDirection * Time.deltaTime * g_Speed);
            }
        }

         

    }
}
