using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public int curHp;
    public int maxHp;
    public int score;
    public float moveSpeed;
    public float jumpJuice;
    public int maxJumps;


    private int jumpsAvalable;
    private float curMoveInput;

    private PlayerController curAttacker;

    [Header("Components")]
    public Rigidbody2D rig;
    public Animator anim;
    public Transform muzzle;

    [Header("combat")]
    public float attackRate;
    private float lastAttackTime;
    public float projectileSpeed;
    public GameObject projectilePrefab;

    private void FixedUpdate()
    {
        Move();
        if(curMoveInput != 0)
        {
            float x = curMoveInput > 0 ? 1 : -1;
            transform.localScale = new Vector3(x, 1, 1);
        }
    }

    private void Move()
    {
        rig.velocity = new Vector2(curMoveInput * moveSpeed, rig.velocity.y);
    }


    private void Jump()
    {
        rig.velocity = new Vector2(rig.velocity.x, 0);
        rig.AddForce(Vector2.up * jumpJuice, ForceMode2D.Impulse);

    }


    public void OnMoveInput(InputAction.CallbackContext context)
    {
        curMoveInput = context.ReadValue<float>();
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            if(jumpsAvalable > 0)
            {
                jumpsAvalable--;
                Jump();
            }
            
        }
    }

    public void OnAttackInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed && Time.time - lastAttackTime > attackRate)
        {
            lastAttackTime = Time.time;
            spawnProjectile();
        }
    }

    private void spawnProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, muzzle.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x * projectileSpeed, 0);
        projectile.GetComponent<FireBall>().setOwner(this);
    }

    public void OnFallInput(InputAction.CallbackContext context)
    {
        Debug.Log("You have fallen");
    }
    public void OnTountInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("Ha Ha I will win");
        }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].point.y < transform.position.y)
        {
            jumpsAvalable = maxJumps;
            GetComponentInChildren<ParticleSystem>().Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponentInChildren<ParticleSystem>().Stop();
    }

    public void TakeDamage(int damage, PlayerController attacker)
    {
        curAttacker = attacker;
        curHp -= damage;

        if (curHp <= 0)
        {
            GameControler.instance.OnPlayerDeath(this, curAttacker);
        }
        // update UI and health bar
    }






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            GameControler.instance.OnPlayerDeath(this, curAttacker);
        }
    }
}
