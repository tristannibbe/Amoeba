using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public UIController uiController;
    public float health;
    public float damage;

    public StatsSystem playerStats;
    private Rigidbody2D playerBody;
    private Collider2D playerCollider;
    private Animator playerAnimController;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        playerAnimController = GetComponent<Animator>();
        playerStats = new StatsSystem(health,damage);
    }


    public void togglePauseScreen (InputAction.CallbackContext context){
        uiController.togglePauseScreen(context);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SendMessage("ApplyDamage", 10);
        }
    }

    public void attack(InputAction.CallbackContext context)
    {
        if (!context.canceled)
        {
            print("attacked");
            playerAnimController.SetTrigger("attack");
        }
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
