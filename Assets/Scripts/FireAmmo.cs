using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class FireAmmo : MonoBehaviour
{
	//public List<GameObject> Ammo;
	//public Transform BulletStart;
	public GameObject BulletStart;
	private GameObject prefab;
	public GameObject Ammo;


	private void Start()
	{
		prefab = Resources.Load("Ammo") as GameObject;
		GameObject.CreatePrimitive(Ammo);
	}
	
	

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Q))
		{
			GameObject Ammo = Instantiate(prefab);
			Ammo.SetActive((true));
			Ammo.transform.position = transform.position + BulletStart.transform.forward * 2;
			
		}

	}

}