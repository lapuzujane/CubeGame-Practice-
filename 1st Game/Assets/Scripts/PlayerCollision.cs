
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public Movement movement;
   

    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle" || CollisionInfo.collider.tag == "SideCubes")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
 

