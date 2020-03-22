using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 6f;
    public float gravity = 20f;
    public float jump = 5f;
    CharacterController controller;
    Vector3 movedirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        controller.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded)
        {
            movedirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            movedirection *= speed;
            if (Input.GetButton("jump"))
            {
                movedirection.y -= jump;

            }
        }
        movedirection.y -= gravity * Time.deltaTime;
        controller.Move(movedirection * Time.deltaTime); 
    }
}
