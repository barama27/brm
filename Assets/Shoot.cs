using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootpoint;
    public float bulletForce = 500f;
    
    private IEnumerator ShootCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            ShootMethod();
        }
    }

    private void Start()
    {
        StartCoroutine(ShootCoroutine());
    }

    private void ShootMethod()
    {
        var bulletClone = Instantiate(bullet, shootpoint.position, shootpoint.rotation);
        Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
        rb.AddForce(shootpoint.forward * bulletForce);
        bulletClone.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
