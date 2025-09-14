using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        Hits++;
        Debug.Log("You've bumped into a thing " + Hits + " times!");
    }

}
