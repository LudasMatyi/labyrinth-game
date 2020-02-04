using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offsetP;

    void Update()
    {
        transform.position = player.position + offsetP;
    }
}
