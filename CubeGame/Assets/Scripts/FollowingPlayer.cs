
using UnityEngine;

public class FollowingPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Transform alo;
    void Update()
    {
        transform.position = player.position + offset;
    }
}
