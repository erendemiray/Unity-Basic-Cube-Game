
using UnityEngine;

public class Trying : MonoBehaviour{
public Rigidbody rb;
public int forceInZ;
public int forceInX;
   
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,forceInZ* Time.deltaTime,ForceMode.Acceleration);
        bool pushingButtonA = Input.GetKey(KeyCode.A);
        bool pushingButtonD= Input.GetKey(KeyCode.D);
        if(pushingButtonA){
            rb.AddForce(-forceInX * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(pushingButtonD){
            rb.AddForce(forceInX* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1){
            FindObjectOfType<gameManagement>().EndGame();
        }
    }
}
