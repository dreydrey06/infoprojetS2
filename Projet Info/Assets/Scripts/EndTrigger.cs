using UnityEngine;

public class EndTrigger: MonoBehaviour {
 
    public ManagerGame managerGame;

    void OnTriggerEnter() {

        managerGame.LevelCompleted();

    }
}