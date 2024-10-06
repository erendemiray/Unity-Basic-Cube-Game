using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManagement : MonoBehaviour
{
    public float RestartDelay;
    public GameObject completedGame;
    public GameObject gameOver;
    bool hasGameEnded = false;
    public void CompletedGame(){
        completedGame.SetActive(true);
    }
   public void EndGame(){
    if(hasGameEnded == false){
    gameOver.SetActive(true);
    hasGameEnded = true;
    Invoke("Restart",RestartDelay);
    }

   }

   void Restart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
