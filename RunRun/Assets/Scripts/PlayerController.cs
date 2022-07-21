using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rigidbody;
    Animator animator;
    Player player;
    SpriteRenderer sp;

    private void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
        animator = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            if(rigidbody.velocity.y == 0) {
                rigidbody.velocity = new Vector2(rigidbody.velocity.x, rigidbody.velocity.y + 6);
                animator.Play("player_jump");
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space)) {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, rigidbody.velocity.y - 5);
            animator.Play("player_idle");
        }
        else if (Input.GetKey(KeyCode.D)){
            sp.flipX = false;
            animator.Play("player_run");
            player.speed = 4;
            
        }
        else if (Input.GetKeyUp(KeyCode.D)) {
            player.speed = 0;
            animator.Play("player_idle");
        }
        else if (Input.GetKey(KeyCode.A)) {
            sp.flipX = true;
            animator.Play("player_run");
            player.speed = -4;
        }
        else if (Input.GetKeyUp(KeyCode.A)) {
            player.speed = 0;
            animator.Play("player_idle");
        }
    }
}
