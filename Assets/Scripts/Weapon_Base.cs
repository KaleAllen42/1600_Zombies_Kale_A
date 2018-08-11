using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Base : MonoBehaviour
{

	private Rigidbody projectile;
	public Weapon Weapon;
	public FloatData projectileSpeed;

	public FloatData DamageEvent;
	//public FloatData projectileUpgrade;

	// Use this for initialization
	private void OnEnable()
	{
		projectile = GetComponent<Rigidbody>();
		projectile.AddForce(0,0,projectileSpeed.Value);   
		Invoke("Deactivate", 5);
	}
   
	private void Deactivate()
	{
		gameObject.SetActive(false);

	}

	//private void OnTriggerEnter(Collider other)
	//{
	//	projectileSpeed = projectileUpgrade;
	//	projectile.AddForce(0, 0, projectileSpeed.Value);
	//}
}
