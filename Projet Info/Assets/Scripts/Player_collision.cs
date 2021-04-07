using UnityEngine;

public class Player_collision : MonoBehaviour

{
	public Player_mouvement mouvement; 

    // Start is called before the first frame update
    void OnCollisionEnter (Collision collisionInfo) 
    {
    	if (collisionInfo.collider.tag == "Obstacle")
    	{
    		mouvement.enabled = false;
    		FindObjectOfType<GameManagerScript>().EndGame();
    	}
    }
}
