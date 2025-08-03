using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpStrength = 10f;
    void Start()
    {
        PrintInstructions();
    }


    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("WELCOME TO THE GAME.");
        Debug.Log("Use WASD move, Space to move up.");
    }
    
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime * jumpStrength;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}