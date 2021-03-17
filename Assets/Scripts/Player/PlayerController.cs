using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody2D playerBody;
    private Collider2D playerCollider;

    private float horizontalInput;
    private float verticalInput;
    private Vector2 moveDir;
    private Animator playerAnimController;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        playerAnimController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(horizontalInput, verticalInput).normalized; 

        if(moveDir != Vector2.zero)
        {
            playerAnimController.SetBool("isMoving", true);
        }
        else
        {
            playerAnimController.SetBool("isMoving", false);
        }

    }

    private void FixedUpdate()
    {
            playerBody.velocity = moveDir * moveSpeed;

    }
}
