
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public  Trying movement;
void OnCollisionEnter(Collision collisionInfo){
if(collisionInfo.collider.tag == "Obstacle"){
    movement.enabled = false;
    FindObjectOfType<gameManagement>().EndGame();
}
}   
}
