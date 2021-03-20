using UnityEngine;

public class Player_mouvement : MonoBehaviour {

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
    	rb.AddForce(0, 0, 2000 * Time.deltaTime);
        
    }
}
