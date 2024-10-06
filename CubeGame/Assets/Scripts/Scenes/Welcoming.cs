using UnityEngine.SceneManagement;
using UnityEngine;
public class Welcoming : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
