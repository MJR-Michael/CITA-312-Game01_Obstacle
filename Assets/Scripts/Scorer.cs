using UnityEngine;

public class Scorer : MonoBehaviour
{
    public AudioSource CollisionAudio;
    int Hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        CollisionAudio.Play();
        if (other.gameObject.tag != "Hit")
        {
            Hits++;
            Debug.Log("You've bumped into " + Hits + " things!");
        }
    }

}
