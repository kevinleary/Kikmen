using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{

    // public Vector3 movement;
    public float speed = 5f;
    public float jumpspeed = .5f;
    //public Rigidbody rb;
    public bool OnGround = true;
    public bool isAirborne = false;
    // Use this for initialization
    void Start()
    {

        //rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

        if (OnGround)                       //testing out jumping not working very well
        {
            if (Input.GetButton("Jump"))
            {
                transform.Translate(0f, jumpspeed , 0f);
                print("Youre Jumping");
                //isAirborne = true;
                OnGround = false;
            }

            if (!OnGround && !Input.GetButton("Jump"))
            {
                transform.Translate(0f, -jumpspeed , 0f);
                print("Youre falling");
            }
            //  else
            //    OnGround = false;
        }
    }
}
