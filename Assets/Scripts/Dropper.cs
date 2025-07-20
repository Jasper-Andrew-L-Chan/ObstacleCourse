using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeTowait = 2f;

    MeshRenderer myRenderer;
    Rigidbody myRigidbody;
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.enabled = false;
        
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeTowait)
        {
            myRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
