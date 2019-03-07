
using UnityEngine;

public class FollowingCube : MonoBehaviour
{
    public Transform player;
    public Vector3 CamPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = (player.position + CamPosition);
        
    }
}
