using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//jj
//ll
//rr
//kk
//ggg
//gg
//heelllo
//hell9o

public class player : MonoBehaviour   
{
    /*CharacterController characterController;*/
    Rigidbody player1;
    Animator animator1;
   
    public float move_Speed = 10f;
    public float gravity = 9.8f;
    public float rot_Speed = 0.15f;
    public float dps = 10f;
    public float jump_Speed = 10f;

    void Awake()
    {
        /*characterController = GetComponent<CharacterController>();*/
        player1 = GetComponent<Rigidbody>();
        /*animator1 = GetComponent<Animator>();*/
       /* animator1.runtimeAnimatorController = Resources.
            Load("Assets/Kevin Iglesias/Basic Motions/AnimationControllers/BasicMotions@Run.controller") as RuntimeAnimatorController;
*/
    }

    // Update is called once per frame
    void Update()
    {

        


        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }*/
       /* Vector3 g = Vector3.zero;
        if (characterController.isGrounded == false)
        {
            g += Physics.gravity;
        }


        characterController.Move(g * Time.deltaTime);*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player1.AddForce(Vector3.up * jump_Speed, ForceMode.Impulse);
        }

        Move();
        Rotate();

    }


    /*void Jump()
    {
        Vector3 jump = Vector3.up * jump_Speed * Time.deltaTime;
       // characterController.transform.position = jump;

        characterController.Move(jump);

    }*/

    private void Rotate()
    {
        Vector3 rot_dir = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rot_dir = transform.TransformDirection(Vector3.left);
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rot_dir = transform.TransformDirection(Vector3.right);
        }

        if (rot_dir != Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation,
                Quaternion.LookRotation(rot_dir), dps * Time.deltaTime);
        }


    }

    void Move()
    {

        /* Debug.Log(Input.GetAxis("Vertical"));
         if (Input.GetAxis("Vertical") > 0)
         {
             Vector3 dir = transform.forward;
             dir.y -= gravity * Time.deltaTime;
             characterController.Move(dir * move_Speed * Time.deltaTime);

         }

         else if (Input.GetAxis("Vertical") < 0)
         {
             Vector3 dir = -transform.forward;
             dir.y -= gravity * Time.deltaTime;
             characterController.Move(dir * move_Speed * Time.deltaTime);
         }


         if (Input.GetKeyDown(KeyCode.Space))
         {

             Vector3 dir = Vector3.zero;
             dir.y += Mathf.Sqrt(1 * -3.0f * gravity);
             characterController.Move(dir * Time.deltaTime);
         }
 */

        float z = Input.GetAxisRaw("Vertical");
        {
            player1.transform.Translate(new Vector3(0, 0, z) * move_Speed * Time.deltaTime);

        }

    }
}
