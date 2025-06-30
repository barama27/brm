using UnityEngine;

public class DummyController : MonoBehaviour
{
    public float speed = 2f;
    public float range = 3f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + Vector3.right * Mathf.Sin(Time.time * speed) * range;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}