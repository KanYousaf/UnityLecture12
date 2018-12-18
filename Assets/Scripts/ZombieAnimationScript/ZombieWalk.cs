using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieWalk : MonoBehaviour {
    private CharacterController controller;
    private Animator anim;

    private Vector3 velocity= Vector3.zero;


    private float turnSpeed = 90.0f;
    private float gravity = 9.8f;

    private float speed = 10.0f;
    private float vSpeed = 0.0f;  //current vertical velocity

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ZombieMovement();
        ZombieAttack();
    }

    void ZombieMovement()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);

        if (controller.isGrounded)
        {
            vSpeed = 0.0f; // grounded character has vSpeed = 0...
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                anim.SetBool("isIdle", false);
                anim.SetBool("isWalking", true);
                velocity = transform.forward * Input.GetAxis("Vertical") * speed;
            }
            else if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                anim.SetBool("isIdle", true);
                anim.SetBool("isWalking", false);
                velocity = Vector3.zero;
            }
        }

        vSpeed -= gravity * Time.deltaTime;
        velocity.y = vSpeed; // include vertical speed in vel
                             // convert vel to displacement and Move the character:
        controller.Move(velocity * Time.deltaTime);
    }

    void ZombieAttack()
    {
        if (controller.isGrounded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(anim.GetBool("isIdle") == true || anim.GetBool("isWalking") == true)
                {
                    anim.SetBool("isIdle", false);
                    anim.SetBool("isWalking", false);
                }
                Attack();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    anim.SetBool("isIdle", false);
                    anim.SetBool("isWalking", true);
                }
                else
                {
                    anim.SetBool("isIdle", true);
                }
            }
        }
    }

    void Attack()
    {
        StartCoroutine(AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        anim.SetBool("isAttacking", true);
        yield return new WaitForSeconds(1.0f);
        anim.SetBool("isAttacking", false);
    }
}
