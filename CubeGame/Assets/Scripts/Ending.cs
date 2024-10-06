
using UnityEngine;

public class Ending : MonoBehaviour
{
    public gameManagement gameManager;
    
    void OnTriggerEnter(){
        gameManager.CompletedGame();
    }
}
