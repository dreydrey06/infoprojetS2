using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
	bool GameHasEnded = false;
	public float restartDelay = 1;

    public void EndGame() {
    	if (GameHasEnded == false)
    	{
            GameHasEnded = true;
    		Debug.Log("Game Over");
    		Invoke("restart", restartDelay);
    	}
    }
    	
    void restart()  {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

        
 

