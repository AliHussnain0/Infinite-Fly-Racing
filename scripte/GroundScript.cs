using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundScript : MonoBehaviour
{
    public static GroundScript current;
    public GameObject[] poolOBj;
    public GameObject s_tile;
        public int poolamount = 4;
        int i =-1;
    int q = -1;
   public  int w = -1;
    public int m=4,b=4,z=4;
    List<GameObject> poolobjects, poolobjectsl,poolobjectsr;

    System.Random rand = new System.Random();
    private void Awake()
    {
        current = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        poolobjects = new List<GameObject>();
        poolobjectsl = new List<GameObject>();
        poolobjectsr = new List<GameObject>();
        for (int j = 0; j < 4; j++)
        {
            if (j == 0)
            {
                for (int i = 0; i < poolamount; i++)
                {
                    GameObject obj = (GameObject)Instantiate(poolOBj[j], ground.instance.end_point, Quaternion.identity);
                    obj.SetActive(true);
                    poolobjects.Add(obj);
                    GameObject obj1 = (GameObject)Instantiate(poolOBj[j], ground.instance.Leftpoint, Quaternion.identity);
                    obj1.SetActive(true);
                    poolobjectsl.Add(obj1);
                    GameObject obj2 = (GameObject)Instantiate(poolOBj[j], ground.instance.rightpoint, Quaternion.identity);
                    obj2.SetActive(true);
                    poolobjectsr.Add(obj2);
                    ground.instance.end_point = obj.transform.GetChild(1).transform.position;
                    ground.instance.Leftpoint = obj1.transform.GetChild(1).transform.position;
                    ground.instance.rightpoint = obj2.transform.GetChild(1).transform.position;
                }
            }
            else if(j==1||j==2)
            {
                for (int i = 0; i < poolamount; i++)
                {

                    int l=rand.Next(1,3);
                    int k=rand.Next(1,3);
                    int t=rand.Next(1,3);
               
                    GameObject obj = (GameObject)Instantiate(poolOBj[l], ground.instance.end_point, Quaternion.identity);
                    obj.SetActive(false);
                    poolobjects.Add(obj);

                    GameObject obj1 = (GameObject)Instantiate(poolOBj[k], ground.instance.Leftpoint, Quaternion.identity);
                    obj1.SetActive(false);
                    poolobjectsl.Add(obj1);
                    GameObject obj2 = (GameObject)Instantiate(poolOBj[t], ground.instance.rightpoint, Quaternion.identity);
                    obj2.SetActive(false);
                    poolobjectsr.Add(obj2);
                    ground.instance.end_point = obj.transform.GetChild(1).transform.position;
                    ground.instance.Leftpoint = obj1.transform.GetChild(1).transform.position;
                    ground.instance.rightpoint = obj2.transform.GetChild(1).transform.position;
                }
            }
            else
            {
                for (int i = 0; i < poolamount; i++)
                {

                    GameObject obj = (GameObject)Instantiate(poolOBj[3], ground.instance.end_point, Quaternion.identity);
                    obj.SetActive(false);
                    poolobjects.Add(obj);
                    GameObject obj1 = (GameObject)Instantiate(poolOBj[3], ground.instance.Leftpoint, Quaternion.identity);
                    obj1.SetActive(false);
                    poolobjectsl.Add(obj1);
                    GameObject obj2 = (GameObject)Instantiate(poolOBj[3], ground.instance.rightpoint, Quaternion.identity);
                    obj2.SetActive(false);
                    poolobjectsr.Add(obj2);
                    ground.instance.end_point = obj.transform.GetChild(1).transform.position;
                    ground.instance.Leftpoint = obj1.transform.GetChild(1).transform.position;
                    ground.instance.rightpoint = obj2.transform.GetChild(1).transform.position;
                }
            }
        }
            
}
    public GameObject gettile()
    {
        Debug.Log(i + "," + q + "," + w);
        i++;
        if (i >= poolobjects.Count)     // again Start from 4 index of array
        {
            i = 4;

        }
        if (poolobjects[i].activeInHierarchy)
        {
            if (i > 4)
            { poolobjects[i - 1].SetActive(false);

                poolobjects[i - 1].transform.position = ground.instance.end_point;

                ground.instance.end_point = ground.instance.end_point + new Vector3(0, 0, 110);



                if (i > 12)
                {
                    poolobjects[b].SetActive(true);
                    b++;
                }
                else
                {
                    poolobjects[i + 3].SetActive(true);
                }
        }
            else if (i <= 4 && i >= 1&& ground.instance.end_point.z< 2460)
            {
                poolobjects[i - 1].SetActive(false);

                Debug.Log("counter1" + ground.instance.counter1);
                poolobjects[i + 3].SetActive(true);


            }
            else if (ground.instance.end_point.z > 1760 && i == 4)
        {
                b = 4;
            poolobjects[15].SetActive(false);
            poolobjects[15].transform.position = ground.instance.end_point;

            ground.instance.end_point = ground.instance.end_point + new Vector3(0, 0, 110);

            { poolobjects[i+3].SetActive(true); }

        }
        

        
            return poolobjects[i];
            }

        
        return null;
    }

    public GameObject gettile1()
    {
        
       
        q++;
        if (q >= poolobjectsl.Count)
        {
            q = 4;

        }
        if (poolobjectsl[q].activeInHierarchy)
        {
            if (q>4)
            {
                poolobjectsl[q - 1].SetActive(false);
                poolobjectsl[q - 1].transform.position = ground.instance.Leftpoint;

                ground.instance.Leftpoint = ground.instance.Leftpoint + new Vector3(0, 0, 110);

                if (q > 12)
                {
                    poolobjectsl[m].SetActive(true);
                    m++;
                }else
                {
                    poolobjectsl[q + 3].SetActive(true);
                }
            }
            else if (q<=4 && q >=1 && ground.instance.end_point.z < 2460)
            {
                poolobjectsl[q - 1].SetActive(false);
                
                        Debug.Log("counter1" + ground.instance.counter1);
                        poolobjectsl[q + 3 ].SetActive(true);
                    
                
            }
            else if (ground.instance.Leftpoint.z > 1760 && q == 4)
            {
                m = 4;
                poolobjectsl[15].SetActive(false);
                poolobjectsl[15].transform.position = ground.instance.Leftpoint;
              
                ground.instance.Leftpoint = ground.instance.Leftpoint + new Vector3(0, 0, 110);
               
                        Debug.Log("counter1" + ground.instance.counter1);
                        poolobjectsl[q + 3].SetActive(true);
                    
                
            }
            
            return poolobjectsl[q];
        }


        return null;
    }
    public GameObject gettile3()
    {
        w++;
        if (w >= poolobjectsr.Count)
        {
            w = 4;

        }
        if (poolobjectsr[w].activeInHierarchy)
        {
            if (w>4)
            {
                poolobjectsr[w - 1].SetActive(false);
                poolobjectsr[w - 1].transform.position = ground.instance.rightpoint;
                ground.instance.rightpoint = ground.instance.rightpoint + new Vector3(0, 0, 110);

                if (w > 12)
                {
                    poolobjectsr[z].SetActive(true);
                    z++;
                }
                else
                {
                    poolobjectsr[w + 3].SetActive(true);
                }
            }
            else if (w <= 4 && w >= 1 && ground.instance.end_point.z < 2460)
            {
                poolobjectsr[w - 1].SetActive(false); 


                Debug.Log("counter2" + ground.instance.counter2);
                poolobjectsr[w + 3].SetActive(true);

            }
            else if (ground.instance.rightpoint.z > 1760 && w == 4)//1760,1320    step no 15
            {
                z = 4;
                poolobjectsr[15].SetActive(false);
                poolobjectsr[15].transform.position = ground.instance.rightpoint;
                
                ground.instance.rightpoint = ground.instance.rightpoint + new Vector3(0, 0, 110);
               
                        Debug.Log("counter2" + ground.instance.counter2);
                        poolobjectsr[w + 3 ].SetActive(true);
                 

            }
            
            return poolobjectsr[w];
        }


        return null;
    }

    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(1);
    }
    public void Mainmenu()
    {
        Debug.Log("Mainmenu");
        SceneManager.LoadScene(0);

    }
}
