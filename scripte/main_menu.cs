using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class main_menu : MonoBehaviour
{
    public static main_menu instance;
   public  GameObject CanvasObject;
    public GameObject CanvasObject2;
    public GameObject musicdisable;
    public GameObject musicenable;
    public GameObject scroll;
    public bool[] ownd;
    public Text Credit;
    public int plane_no;
    // Start is called before the first frame update
    
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        plane_no = PlayerPrefs.GetInt("plane");
        if (plane_no < 1 || plane_no >= 12)
        {
            plane_no = 1;
        }
        
            Credit.text = PlayerPrefs.GetInt("credit").ToString();
        for (int i = 0; i < 11; i++)
        { 
            ownd[i]= PlayerPrefs.GetInt("planes" + i)==1;  //check if the plane is under authority
        }
       
    }


        public void PLAY()
    {
        plane_no = PlayerPrefs.GetInt("plane");
        if (plane_no < 1 || plane_no >= 12)
        {
            plane_no = 1;
        }
        for (int i = 0; i < 11; i++)
        {
            owned_planes(i);  // save owned planes
        }

        Credit.text = PlayerPrefs.GetInt("credit").ToString();
        SceneManager.LoadScene(1);
    }
    
    public void STORE()
    {Debug.Log("store tab openned");
        EnableCanvas();
    }
    public void EnableCanvas()
    {
        CanvasObject.GetComponent<Canvas>().enabled = true;
        CanvasObject2.GetComponent<Canvas>().enabled = false ;
    }
    public void backtomenu()
    {
        CanvasObject.GetComponent<Canvas>().enabled = false;
        CanvasObject2.GetComponent<Canvas>().enabled = true;
    }
    public void musicenable1()
            {
        musicenable.SetActive( false );
        musicdisable.SetActive(true);

    }
    public void musicdisable1()
    {
        musicenable.SetActive(true);

        musicdisable.SetActive(false);
    }
    public void exit()
    {
        Application.Quit();
    }
   
    public void Change_plane(int x)
    {
        Debug.Log("change plane " + x);
        int a = total_score.instance.total_credits();
        if (a >= 10000 && x != 1 && ownd[x-1] == false) {
           total_score.instance.decrement();
            Credit.text = total_score.instance.total_credits().ToString();
            PlayerPrefs.SetInt("plane", x);
            ownd[x-1] = true;   
            plane_no = x;
        }else if (ownd[x-1] == true)
        {

            Debug.Log("You ownd it"); 
            PlayerPrefs.SetInt("plane", x);
            plane_no = x;
        }
        else
        { 
            Debug.Log("You Don't HAVE ENOUGH CREDITS");

            plane_no = 1;
            PlayerPrefs.SetInt("plane", plane_no);
        }
    }
    void owned_planes(int plane)
    { 
        PlayerPrefs.SetInt("planes" + plane, ownd[plane] ? 1:0);

    }
   
}
