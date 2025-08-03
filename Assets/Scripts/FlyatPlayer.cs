using System;
using UnityEngine;

public class FlyatPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float Speed = 1.0f;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }



    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();

    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Speed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }

        
    }
}
