using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 2f;
    MeshRenderer myMeshRender;
    Rigidbody myRigidBody;

    void Start()
    {
        myMeshRender = GetComponent<MeshRenderer>();
        myMeshRender.enabled = false;

        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
    }
    void Update()
    {
        float TotalTime = Time.time;

        if (TotalTime > TimeToWait)
        {
            Debug.Log("Lookout Below!");
            myMeshRender.enabled = true;
            myRigidBody.useGravity = true;

        }
    }
}
 