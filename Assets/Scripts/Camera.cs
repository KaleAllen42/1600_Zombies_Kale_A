using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	public GameObject ThirdPersonPlayer;
	public GameObject MainCamera;
	public GameObject CameraFollowObj;
	
  

	void Start()
	{
		MainCamera.transform.position -= ThirdPersonPlayer.transform.TransformVector(0,0,01);
	}

	void Update()
	{
		transform.LookAt(CameraFollowObj.transform);
	}

   
}