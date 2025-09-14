using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 10f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;

    void Start()
    {

    }

    void Update()
    {
        Spinning();
    }

    void Spinning()
    {
        float xValue = xAngle * Time.deltaTime;
        float yValue = yAngle * Time.deltaTime;
        float zValue = zAngle * Time.deltaTime;
        transform.Rotate(xValue, yValue, zValue);
    }
}
