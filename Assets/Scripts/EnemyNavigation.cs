using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    NavMeshAgent agent;
    Transform destination;
    public bool isMaster;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (isMaster)
        {
            destination = FindObjectOfType<CharacterController>().transform;
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("Master").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destination.position;
    }
}
