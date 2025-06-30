using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 5;
    public float rotateSpeed = 100;

    private void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * movespeed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
    }
}
