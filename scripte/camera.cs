
using UnityEngine;
 
public class camerax : MonoBehaviour
{
    
    public Transform[] player;
    Transform plane;
    public float moveSpeed = 50f;
    Vector3 offset;
  
     void Start()
    {
        //xw = main_menu.instance.plane_no;
        plane=player[main_menu.instance.plane_no -1];
;        offset = transform.position - plane.position;
       // Debug.Log("POSITION"+player[main_menu.instance.plane_no - 1]);  
        //Debug.Log("OFFSET"+offset);  

    }
    // Update is called once per frame 
    private void FixedUpdate()
    {

       // xw = main_menu.instance.plane_no;
        Vector3 targetpos = plane.position + offset;
        //Debug.Log("POSITION" + plane.position);
      //  Debug.Log(targetpos);
        // targetpos.x = 0;
        transform.position = targetpos;

        // HandelTouch();
    }

}
