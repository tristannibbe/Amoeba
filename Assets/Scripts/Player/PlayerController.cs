using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody2D playerBody;
    private Collider2D playerCollider;

    private Animator playerAnimController;


    private void Awake()
    {
    }

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        playerAnimController = GetComponent<Animator>();

    }

    void Update()
    {


    }



    public void Move(InputAction.CallbackContext context)
    {
        Vector2 dir = context.ReadValue<Vector2>();
        playerBody.velocity = dir * moveSpeed;

        if(dir != Vector2.zero)
        {
            playerAnimController.SetBool("isMoving", true);
        }
        else
        {
            playerAnimController.SetBool("isMoving", false);
        }

    }
}
