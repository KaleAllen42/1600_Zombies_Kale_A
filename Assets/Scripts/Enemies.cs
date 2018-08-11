using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemies : MonoBehaviour 
{


	private NavMeshAgent Agent;
	public Transform Destination;
	public AI Control;
	public FloatData Damage;
	private FloatData Health;
	public GameObject Zombie;
	public  Weapon_Base DamageEvent;
	public Zombie_stats ZombieStats;
	
	
	void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
		Control.ConfigAI(Agent);
		
		

	}
	
	
	void Update () 
	{
		Agent.destination = Destination.position;
	}
	
	private void OnTriggerEnter(Collider weaponbase)
	{
		Damage.Value -= Health.Value;
		if (Health.Value >= 0)
		{
			Destroy(Zombie);
			Debug.Log("Dead");
		}

	}
}
