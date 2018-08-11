using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[CreateAssetMenu]
public class AI : ScriptableObject
{

	public Zombie_stats ZombieStats; 
	public float AngularSpeed;

	public void ConfigAI(NavMeshAgent agent)
	{
		agent.speed = ZombieStats.ZombieSpeed;
		agent.angularSpeed = AngularSpeed;
	}
}
