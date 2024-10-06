
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreBoard;
        void Update()
    {
        float playerPositionZ = player.position.z + (float)257.09;
        scoreBoard.text = playerPositionZ.ToString("0");
    }
}
