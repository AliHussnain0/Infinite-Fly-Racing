

using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class total_score : MonoBehaviour
{    public static total_score instance;
    public Text tExt;
    protected float score = 0;
    protected int high=0;
    protected float flag=0;
    public Text Total_Credits;
    

    public Image back;
   protected  int total_credit=0 ;
    public  Text high_score;
    public GameObject[] object1;

    MoveObject obj;
    // Start is called before the first frame update
    private void Awake()
    {
         instance = this;
        Debug.Log(2);
    }
    private void Start()
    {
        //.// object1[main_menu.instance.plane_no - 1];
        obj = GameObject.FindObjectOfType<MoveObject>();
        high= PlayerPrefs.GetInt("High");
        total_credit= PlayerPrefs.GetInt("credit");
        Debug.Log("itshigh :" + high);
        high_score.text =(int) (high )+'m'.ToString();
    }
    // Update is called once per frame
    void Update()

    {
      score = object1[main_menu.instance.plane_no - 1].transform.position.z;
       
        tExt.text = (int)( score  ) + "m".ToString();
       if(obj.alive == true && score <= 999)
        {
            flag = 0;
            high_score.text = (int)(high ) + "m".ToString();
            tExt.text = (int)(score) + "m".ToString();
        }else if (obj.alive == true)
        {
            flag = 0;
            high_score.text = (int)(high) + "m".ToString();
            tExt.text = (int)(score/1000) + "km".ToString();
        }
    }
    public void save_pref()
    {
       // if (obj.alive == false)
       // {
            Debug.Log("verifing save pref");
            if (score > high)
            {
                high = (int)score;
                high_score.text = (int)(high) + "m".ToString();
                score = 0;
            }
            flag = 1;
            score = 0;
            total_credit = total_credit + GameObject.FindObjectOfType<MoveObject>().credit;
            Total_Credits.text = GameObject.FindObjectOfType<MoveObject>().credit.ToString();
            GameObject.FindObjectOfType<MoveObject>().UPD_Credit(0);
     //   }
       /*8 else if (obj.alive == false && flag == 0)
        {
            if (score > high)
            {
                high = (int)score;
                high_score.text = (int)(high / 1000) + "m".ToString();
                score = 0;
            }
            flag = 1;
            score = 0;
            total_credit = total_credit + GameObject.FindObjectOfType<MoveObject>().credit;
            Total_Credits.text = GameObject.FindObjectOfType<MoveObject>().credit.ToString();

            GameObject.FindObjectOfType<MoveObject>().credit = 0;
        }*/
        PlayerPrefs.SetInt("High",high);
        PlayerPrefs.SetInt("credit", total_credit);

    }
    public void decrement()
    {
        total_credit -= 10000;
        PlayerPrefs.SetInt("credit", total_credit);
    }
    public int total_credits()
    {
        return total_credit;
    }
}
