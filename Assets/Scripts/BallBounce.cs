using System.Collections;
using System.Collections.Generic;
using UnityEditor.TerrainTools;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallBounce : MonoBehaviour
{

    public GameObject BallObj;
    public GameObject SliderObj;   
    int g_BallSpeed;
    int g_Speed;
    Vector3 g_BallDirection = Vector3.zero;
    Rigidbody BallRigidbody;
    bool BallIsInActive = true;
    Vector3 g_MoveDirection = Vector3.zero;
    public UIControlScript UIManager;
    public DuplicateBrick GameManager;
   
    float BallXpos;
    float BallYpos;
    float BallZpos;

    int g_Score;
    int g_BallLifes;


    // Start is called before the first frame update

    void Start()
    {

        UIManager.HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
       // UIManager.HighScore1.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        g_BallSpeed = 5;
        g_Speed = 25;
        g_BallLifes = 5;
        BallRigidbody = BallObj.GetComponent<Rigidbody>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        m_MoveBall();
        m_GameOver();
        BallXpos = SliderObj.transform.position.x;
        BallYpos = SliderObj.transform.position.y + 1.6f;
        BallZpos = SliderObj.transform.position.z;
    }

   

    void m_MoveBall()
    {
        if (BallIsInActive == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (BallObj.transform.position.x > -22f)
                {
                    g_MoveDirection = Vector3.left;
                    BallObj.transform.Translate(g_MoveDirection * Time.deltaTime * g_Speed);
                }
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (BallObj.transform.position.x < 24f)
                {
                    g_MoveDirection = Vector3.right;
                    BallObj.transform.Translate(g_MoveDirection * Time.deltaTime * g_Speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {

                g_BallDirection = new Vector3(1, 1);
                BallRigidbody.AddForce(g_BallDirection * 600f);
                BallIsInActive = false;
            }
            
        }

        BallObj.transform.Translate(g_BallDirection * Time.deltaTime * g_BallSpeed);
    }

    void m_GameOver()
    {
        if(BallObj.transform.position.y < -16f)
        {
             BallObj.transform.position = new Vector3(BallXpos,BallYpos,BallZpos);
             
             g_BallDirection = Vector3.zero;
             BallRigidbody.velocity = Vector3.zero;
             BallIsInActive = true;
             g_BallLifes -= 1;
             UIManager.g_LifeText.text = g_BallLifes.ToString();
             
            if (g_BallLifes == 0)
            {
                UIManager.GameOverPanel.SetActive(true);
            }
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Brick")
        {
            collisionInfo.collider.gameObject.SetActive(false);
            g_Score++;

            UIManager.g_ScoreText.text = g_Score.ToString();


            if (g_Score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", g_Score);
                UIManager.HighScore.text = g_Score.ToString();
              //  UIManager.HighScore1.text = g_Score.ToString();
            }

            if (g_Score == GameManager.Colunms * GameManager.Rows)
            {
                UIManager.GameOverPanel.SetActive(true);
                
            }




        }

        Vector3 Direction1 = collisionInfo.GetContact(0).normal;

        if(Direction1 == Vector3.down)
        {
            g_BallDirection.y = - g_BallDirection.y;
        }
        if(Direction1 == Vector3.up)
        {
            g_BallDirection.y = -g_BallDirection.y; 
        }
        if(Direction1 == Vector3.left)
        {
            g_BallDirection.x = -g_BallDirection.x; 
        }
        if(Direction1 == Vector3.right)
        {
            g_BallDirection.x = -g_BallDirection.x;
        }

        BallRigidbody.velocity = Vector3.zero;
        BallRigidbody.AddForce(g_BallDirection * 600f);


    }
    
}
