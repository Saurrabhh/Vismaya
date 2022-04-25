using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController characterController;
    private Anim playerAnim;
    //private dooranim doorAnim;
    private Vector3 moveDirection;
    public float speed = 5f;
    public float gravity = 8f;
    public float jumpForce = 15f;
    public float verticalVelocity = 10f;




    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        playerAnim = GetComponent<Anim>();
        //doorAnim = new dooranim();
    }

    // Update is called once per frame
    void Update()
    {
        MovethePlayer();
        AnimateWalk();
        
    }

    void MovethePlayer()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed * Time.deltaTime;

        //if(!characterController.isGrounded)
        ApplyGravity();

        characterController.Move(moveDirection);
    }

    void ApplyGravity()
    {
       
      if(verticalVelocity > -500f)
          verticalVelocity -= gravity * Time.deltaTime;

            PJump();

        moveDirection.y = verticalVelocity * Time.deltaTime;
    }

    void PJump()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            verticalVelocity = jumpForce;
            AnimateJump();
            //Debug.Log(Input.GetKeyDown(KeyCode.Space));

        }
    }


    void AnimateWalk()
    {
        if(characterController.velocity.sqrMagnitude >= 2)
        {
            playerAnim.Walk(true);
        }
        else
        {
            playerAnim.Walk(false);
        }
    }


    void AnimateJump()
    {
        playerAnim.JumpAnim();
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "Door")
    //    {
    //        doorAnim.animatedoor();
            
    //    }
    //    Debug.Log(other.tag);
    //}

  

}
