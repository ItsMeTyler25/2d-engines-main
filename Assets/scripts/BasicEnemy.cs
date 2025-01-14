using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine; 
using UnityEngine.AI;

public class BasicEnemy: MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    public int curFrame = 1;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        player = GameObject.FindWithTag("Player");
    }

    void onUpdate()
    {
        agent.speed = agent.remainingDistance / 2;
    }

    void startSlime()
    {
        agent.SetDestination(player.transform.position);
    }

    void stopSlime()
    {
        agent.ResetPath();
    }
}