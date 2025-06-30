using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    [SerializeField] private float detectDistance;
    [SerializeField] private float closingDistance;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform player;

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(transform.position, player.position);
        if (distance < detectDistance && distance > closingDistance)
        {
            agent.SetDestination(player.position);
        }
    }
}
