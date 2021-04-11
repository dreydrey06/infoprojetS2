using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressEnterToStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return)){
            Debug.Log("enter");
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
