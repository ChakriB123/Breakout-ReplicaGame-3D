using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateBrick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BrickObj;
    public int Rows;
    public int Colunms;
    public GameObject[] BrickClonesArray;
    public Transform Parent;
    public Vector3 StartPos;
    float Xpos;
    float Ypos;

    int Index = 0;


         void Start()
         {
           
            DuplicateBricks();
            
         }

         void DuplicateBricks()
         {

            BrickClonesArray = new GameObject[Rows * Colunms];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Colunms; j++)
                {

                    Xpos = StartPos.x + (BrickObj.transform.localScale.x +1f) * i;
                    Ypos = StartPos.y + (BrickObj.transform.localScale.y +1f)* j;

                    Vector3 Position = new Vector3(Xpos, Ypos , StartPos.z);

                    BrickClonesArray[Index] = Instantiate(BrickObj, Position, Quaternion.identity, Parent);
                    BrickClonesArray[Index].name = "Brick" + Index;

                    Index++;


                }
            }

         }
}
