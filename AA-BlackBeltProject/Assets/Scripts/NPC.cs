using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour, iInteractable
{
    public Vector3[] npcPos;
    NavMeshAgent myNavMeshAgent;
    int index;

   

    public void interact()
    {
       // NPC stuff;
    }

    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        index = Random.Range(0, npcPos.Length);
        myNavMeshAgent.SetDestination(npcPos[index]);
    }

    void Update()
    {
        if(myNavMeshAgent.remainingDistance < 2)
        {
            index = Random.Range(0, npcPos.Length);
            myNavMeshAgent.SetDestination(npcPos[index]);
        } 
    }
}
