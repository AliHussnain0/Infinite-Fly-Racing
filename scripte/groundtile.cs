
using System;
using UnityEngine;
using UnityEditor;
public class groundtile : MonoBehaviour
{
    // Start is called before the first frame update
    ground Ground;
    private void Start()
    {
        Ground = GameObject.FindObjectOfType<ground>();
    }
    private void OnTriggerExit(Collider other)
    {
      
       // Debug.Log("count: " +Ground.counter++);//to note that how many times this trigger function is being called and 
                                                //then control the tiles spwanrate accordingly
    //  if(Ground.counter%2==0&& GameObject.FindObjectOfType<MoveObject>().alive==true)
 {

           // if (Ground.counter==90)
            {
                //Ground.point = 2;
            }
        
                Ground.Spwaner1();
                Debug.Log("1");
            
      
                Ground.Spwaner2();
                Debug.Log("2");
            
         
                Ground.Spwaner3();
                Debug.Log("3");
            
           
            
       }
        
          
  }
    private void Destroy()
    {
        gameObject.SetActive(false);
    }

}

  

