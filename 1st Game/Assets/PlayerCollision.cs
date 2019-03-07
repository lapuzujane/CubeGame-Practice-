
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;

    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
 

