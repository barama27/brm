using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpforce = 300;
    public float JumpDetectionDistance = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, Vector3.down, JumpDetectionDistance))
            {
                GetComponent<Rigidbody>().AddForce(0, jumpforce, 0);
            }
        }
        Debug.DrawRay(transform.position, Vector3.down * JumpDetectionDistance, Color.red);
    }
}
