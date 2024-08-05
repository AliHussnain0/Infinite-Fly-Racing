
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;

public class MoveObject : MonoBehaviour
{
    static public MoveObject instance;
    [SerializeField] protected ParticleSystem _ParticleSystem = default;
    public float moveSpeed = 5f; // Speed of manual left and right movement
    public float autoMoveSpeed = 3f; // Speed of automatic forward movement
    private float LRmovement;
    public Rigidbody rb;
    public float bendSpeed = 10f; // Speed of bending
    public float maxBendAngle = 90f; // Maximum angle to bend
     public GameObject player;
    public    bool alive=true;
    int vs = 1;
    public int t;
    public int credit;
    public GameObject CanvasObject;   
    public GameObject CanvasObject2; 
    private void Awake()
    {
        Application.targetFrameRate = 60;
        instance
            = this;
    }
    

 
    private void FixedUpdate()
    {
        if (!alive) {
            return; }
     //   acceleration();
       
        Vector3 forward = transform.forward * autoMoveSpeed * Time.deltaTime ;
        Vector3 side = transform.right * LRmovement * moveSpeed * Time.deltaTime * 2;
        rb.MovePosition(rb.position + forward + side); 
      LRmovement = Input.acceleration.x;


        // Calculate the bend angle based on the accelerometer input
      ///  LRmovement = Input.GetAxis("Horizontal");
      
        float bendAngle = LRmovement * maxBendAngle;
    //    bendAngle= Mathf.Atan2(LRmovement,0)*Mathf.Rad2Deg;
        // Clamp the bend angle to ensure it doesn't exceed the maximum angle
        bendAngle = Mathf.Clamp(bendAngle, -maxBendAngle, maxBendAngle);
       

        // Create a target rotation based on the bend angle
        Quaternion targetRotation = Quaternion.Euler(0, 0,-bendAngle);

            // Smoothly interpolate between current rotation and target rotation
          transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, bendSpeed * Time.deltaTime);
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstecle")
        {  die();
            GameObject.FindObjectOfType<total_score>().save_pref();
            CanvasObject.GetComponent<Canvas>().enabled = false;
            CanvasObject2.GetComponent<Canvas>().enabled = true;
        player.GetComponent<MeshRenderer>().enabled=(false);
        }
        else if (other.gameObject.tag == "score")
        {

            credit+=500;
            GroundScript.current.s_tile.SetActive(false);
        }   }

    private void die()
    {
        _ParticleSystem.transform.position = player.transform.position;
        autoMoveSpeed = 0f;
        moveSpeed = 0f;
       alive = false;
        _ParticleSystem.Play();

    }
    public void UPD_Credit(int i )
    {
        credit = i;

    }
    public int Ccredit()
    {
        return credit;
    }
    void acceleration()
    {
        if (transform.position.z >= vs * 1781 && transform.position.z <= vs * 1785 && t > 0)
        {
            if (t <= 4)
            {
                t++;
                vs++;
                autoMoveSpeed += 20;
            }

        }
    }
}