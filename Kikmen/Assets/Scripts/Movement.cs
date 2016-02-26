using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

   // public Vector3 movement;
    public float speed = 5f;
    //public Rigidbody rb;

    // Use this for initialization
    void Start () {

        //rb = GetComponent<Rigidbody>();

     }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
        
    }
}
