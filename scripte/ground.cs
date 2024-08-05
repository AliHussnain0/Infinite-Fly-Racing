using System.Net;
using Unity.VisualScripting;
using System;
using UnityEngine;

public class ground : MonoBehaviour
{
    Mesh[] meshs;
    public static ground instance;
    public int counter = 3;
    public int counter1 = 3;
    public int counter2 = 3;
    public GameObject plane1;
    public GameObject plane2;
    public GameObject plane3;
    public GameObject plane4;
    public GameObject plane5;
    public GameObject plane6;
    public GameObject plane7;
    public GameObject plane8;
    public GameObject plane9;
    public GameObject plane10;
    public GameObject plane11;
    public int x;
    // GameObject[] groundTile;
    //public GameObject[] groundTile1;
    //int Flag1 = 1, Flag2 = 1;
  public int point;

    public Vector3 end_point;
    public Vector3 rightpoint = new Vector3(200f, 0, 0);
    public Vector3 Leftpoint = new Vector3(-200f, 0, 0);

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
      change_planes();
    }

    public void Spwaner1()
    {
        counter++;

        if (point == 1)
        {
           
                GameObject temp = GroundScript.current.gettile();
            if (temp == null) return;
         //  temp.SetActive(true);


        }
       /* else if (point == 2)
        {
            // i = 1 % i;
            Debug.Log("TEST_PURPOSE:");
            GameObject temp = Instantiate(groundTile1[0], end_point, Quaternion.identity);

            end_point = temp.transform.GetChild(1).transform.position;

        }*/
        // counter++;


    }
    public void Spwaner2()
    {
        counter1++;
        if (point == 1 )
        {
            
                GameObject temp = GroundScript.current.gettile1();
                if (temp == null) return;
             //   temp.SetActive(true);
            
        }
        /*else if (point == 2)
        {

            //   j = 1 % j;
            GameObject temp1 = Instantiate(groundTile1[0], rightpoint, Quaternion.identity);

            rightpoint = temp1.transform.GetChild(1).transform.position;
        }
        8

        Debug.Log(rightpoint);*/
        /*  if (GameObject.FindObjectOfType<MoveObject>().transform.position.x < 200)
          {
              if (Leftpoint.x > 0 && Flag1 == 0)
              {
                  Flag1 = 1;
                  Debug.Log("one");
                  Leftpoint.z = 100 + GameObject.FindObjectOfType<MoveObject>().transform.position.z;
                  Leftpoint.x = rightpoint.x - 200;
                  for (int i = 0; i < 6; i++)
                  {
                      Debug.Log("six");
                      Spwaner3(j);
                  }
              }
          }
          else if (GameObject.FindObjectOfType<MoveObject>().transform.position.x >= 100 && Flag1==1)
          {

              Flag1 = 0;
              Debug.Log("one");
                      Leftpoint.z = 100+GameObject.FindObjectOfType<MoveObject>().transform.position.z;
                      Leftpoint.x = rightpoint.x + 200;
                  for (int i = 0; i < 6; i++)
                  {
                  Debug.Log("six");
                      Spwaner3(j);
                  }


          }*/

    }

    public void Spwaner3()
    {
        counter2++;

        if (point == 1 )
        {
             GameObject temp = GroundScript.current.gettile3();
                if (temp == null) return;

                ///temp.SetActive(true);
            
        }
       /*  else if (point == 2)
        {
            //k = 1 % k;

            GameObject temp2 = Instantiate(groundTile1[0], Leftpoint, Quaternion.identity);

            Leftpoint = temp2.transform.GetChild(1).transform.position;
        }
       if (GameObject.FindObjectOfType<MoveObject>().transform.position.x > -200)
        {
            if (rightpoint.x < 0 && Flag2 == 0)
            {
                Flag2 = 1;
                rightpoint.z = 100 + GameObject.FindObjectOfType<MoveObject>().transform.position.z;
                rightpoint.x = Leftpoint.x + 200;
                for (int i = 0; i < 5; i++)
                {
                    Spwaner2(k);
                }
            }
        }
        else if (GameObject.FindObjectOfType<MoveObject>().transform.position.x <= -100 && Flag2 == 1)
        {
            Debug.Log("one");

            Flag2 = 0;
            rightpoint.z = 100 + GameObject.FindObjectOfType<MoveObject>().transform.position.z;
            rightpoint.x = Leftpoint.x - 200;
            for (int i = 0; i < 5; i++)
            {
                Debug.Log("six");
                Spwaner2(k);
            }

        }*/
    }
    private void change_planes()
    {
        x = main_menu.instance.plane_no;
        if (main_menu.instance.plane_no <1|| main_menu.instance.plane_no>11)
        {
            x = 1;
        }
    

        Debug.Log("camera x" +x);
        if (x == 1)
        {
            plane1.SetActive(true);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(false);
            plane5.SetActive(false);
            plane6.SetActive(false);
            plane7.SetActive(false);
           plane8.SetActive(false);
            plane9.SetActive(false);
            plane10.SetActive(false);
           plane11.SetActive(false);
        }
        else if (x == 2)
        {
           plane1.SetActive(false);
           plane2.SetActive(true);

           plane3.SetActive(false);
           plane4.SetActive(false);
           plane5.SetActive(false);
           plane6.SetActive(false);
           plane7.SetActive(false);
           plane8.SetActive(false);
           plane9.SetActive(false);
           plane10.SetActive(false);
           plane11.SetActive(false);
        }
        else if (x == 3)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(true);
            plane4.SetActive(false);
            plane5.SetActive(false);
            plane6.SetActive(false);
            plane7.SetActive(false);
            plane8.SetActive(false);
            plane9.SetActive(false);
            plane10.SetActive(false);
            plane11.SetActive(false);
        }
        else if (x == 4)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(true);
            plane5.SetActive(false);
            plane6.SetActive(false);
            plane7.SetActive(false);
            plane8.SetActive(false);
            plane9.SetActive(false);
            plane10.SetActive(false);
            plane11.SetActive(false);

        }
        else if (x == 5)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(false);
            plane5.SetActive(true);
            plane6.SetActive(false);
            plane7.SetActive(false);
            plane8.SetActive(false);
            plane9.SetActive(false);
            plane10.SetActive(false);
            plane11.SetActive(false);

        }
        else if (x == 6)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(false);
            plane5.SetActive(false);
            plane6.SetActive(true);
            plane7.SetActive(false);
            plane8.SetActive(false);
            plane9.SetActive(false);
            plane10.SetActive(false);
            plane11.SetActive(false);

        }
        else if (x == 7)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(false);
            plane5.SetActive(false);
            plane6.SetActive(false);
            plane7.SetActive(true);
            plane8.SetActive(false);
            plane9.SetActive(false);
            plane10.SetActive(false);
            plane11.SetActive(false);


        }
        else if (x == 8)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(false);
            plane5.SetActive(false);
            plane6.SetActive(false);
            plane7.SetActive(false);
            plane8.SetActive(true);
            plane9.SetActive(false);
            plane10.SetActive(false);
            plane11.SetActive(false);


        }
        else if (x == 9)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(false);
            plane5.SetActive(false);
            plane6.SetActive(false);
            plane7.SetActive(false);
            plane8.SetActive(false);
            plane9.SetActive(true);
            plane10.SetActive(false);
            plane11.SetActive(false);

        }
        else if (x == 10)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(false);
            plane5.SetActive(false);
            plane6.SetActive(false);
            plane7.SetActive(false);
            plane8.SetActive(false);
            plane9.SetActive(false);
            plane10.SetActive(true);
            plane11.SetActive(false);

        }
        else if (x == 11)
        {
            plane1.SetActive(false);
            plane2.SetActive(false);

            plane3.SetActive(false);
            plane4.SetActive(false);
            plane5.SetActive(false);
            plane6.SetActive(false);
            plane7.SetActive(false);
            plane8.SetActive(false);
            plane9.SetActive(false);
            plane10.SetActive(false);
            plane11.SetActive(true);

        }


    }


}
