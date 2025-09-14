using UnityEngine;

public class Mover : MonoBehaviour
{
    void Start()
    {
        transform.Translate(1, 0, 0);
    }

    void Update()
    {
        transform.Translate(0.01f, 0, 0);

    }
}
