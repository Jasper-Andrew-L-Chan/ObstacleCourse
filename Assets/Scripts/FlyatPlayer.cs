using UnityEngine;

public class FlyatPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float Speed = 1.0f;
    Vector3 playerPosition;

    void Start()
    {
        playerPosition = player.transform.position;
    }

    

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Speed * Time.deltaTime);
    }
}
