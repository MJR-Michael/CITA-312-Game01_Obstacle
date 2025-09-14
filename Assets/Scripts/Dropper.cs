using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 2f;
    void Update()
    {
        float TotalTime = Time.time;

        if (TotalTime > TimeToWait)
        {
            Debug.Log("Lookout Below!");
        }
    }
}
 