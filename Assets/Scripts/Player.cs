using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	
	
    private Vector3 newPosition;
    public float gravity = 20f;
    public float SprintingSpeed = 20.0f;
    public float DefaultSpeed = 10.0f;
    public float rotatespeed = 5.0f;
    public GameObject player;
    private Vector3 moveDirection;
    public float jumpForce = 0.01f;
    private Vector3 Offset = new Vector3();



    // Use this for initialization
    void Start () 
    {
		
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
		
    }
	
	
	
	
    // Update is called once per frame
    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= DefaultSpeed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpForce;
        }
		
        // defines sprinting method
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            DefaultSpeed += SprintingSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            DefaultSpeed = 10.0f;
        }

      
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
		
		
		
       
        float horizontal = Input.GetAxis("Mouse X") * rotatespeed;
        player.transform.Rotate(0, horizontal, 0);
        float desiredAngle = player.transform.eulerAngles.y;
        Quaternion roatation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = player.transform.position - (roatation * Offset);
    }
}
