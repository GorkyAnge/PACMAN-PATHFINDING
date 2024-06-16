using UnityEngine;
using UnityEngine.AI;

public class GhostMovement : MonoBehaviour
{
    public Transform pacman;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (pacman != null)
        {
            agent.SetDestination(pacman.position);
        }
    }
}

