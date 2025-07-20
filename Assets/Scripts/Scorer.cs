using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name != "Platform")
        {
            
        if (other.gameObject.tag != "Hit")
            {
                hits = hits + 1;
                Debug.Log("You bimped into a thing this many times: " + hits);
            }

            }
            
        }
}
