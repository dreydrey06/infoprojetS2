using UnityEngine;
using System.Collections;

public class Player_mouvement : MonoBehaviour {

    public Rigidbody rb;
    public Transform player;
    public float FowardForce = 1000f;
    public float sidewaysForce = 100f;
    public float UpForce = 50f;  // Variable that determines the sideways force

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        // Adding foward force
    	rb.AddForce(0, 0, FowardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.UpArrow) && player.position.y < 2f) 
        {
            // Add a force to the top
            rb.AddForce(0, UpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y < -5f) {
           FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
