using UnityEngine;

public class ShootWithRaycast : MonoBehaviour
{
    public GameObject Bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit,100, 1 << 3 | 1 << 6))
            {
                //hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
                //Instantiate(Bullet, hit.point, Quaternion.identity);
            }

            var hitArray = Physics.RaycastAll(transform.position, transform.forward,100);
            foreach (var hitt in hitArray)
            {
                Instantiate(Bullet, hitt.point, Quaternion.identity);
            }
        }
    }
}
