using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;

    [SerializeField]
    private Transform local;

    void Start()
    {
       IA();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
      void IA()
    {
            agent.destination = local.position;
           
               
           
    }    
}
