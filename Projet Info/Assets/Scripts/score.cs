using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{    
	public Transform player;
	public Text gamescore;
	public float playerpos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	playerpos = player.position.z + 46;
    	gamescore.text = playerpos.ToString("0");
    }
}
