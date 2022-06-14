using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmovement : MonoBehaviour
{
    //Movement Vars
    public float speed = 10f;
    public float jumpPower = 15f;

    //Abilities
    public bool doubleJump; //Dani
    public bool bigStength; //Lew
    public bool shrink; //Rach
    public bool canDash; //Connor

    //Shrinking Vars
    public bool isshrunk = false;

    //Double Jump Vars
    private float jumpTotal = 1;

    //Dashing Vars
    private bool isDashing;
    private float dashingpower ;
    private float dashingTime = 0.23f;
    private float dashingCooldown = 1f;
    [SerializeField] TrailRenderer tr;

    //Physics and Ground
    [SerializeField] public LayerMask groundLayer;
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] Transform feet;
    [SerializeField] SpriteRenderer sprite;

    //Vars
    bool isGrounded;
    public float mx;
    float jumpCoolDown;

    //Animation
    public Animator spriteAnims;

    //Particle
    public ParticleSystem Dust;

    private void Start()
    {
        rb= GetComponent<Rigidbody2D>(); 
    }
    private void FixedUpdate()
    {
        //Dashing
        if(isDashing)
        {
            return;
        }
        //Movement
        rb.velocity = new Vector2(mx * speed, rb.velocity.y);
    }
    private void LateUpdate()
    {
        //Dashing
        if (isDashing)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }

        //Movement
        mx = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        CheckGrounded();
        FlipSprite();
        WalkingAnim();

        //Shrink
        if (Input.GetKeyDown(KeyCode.LeftShift) && shrink == true && isshrunk == false)
        {
            StartCoroutine(shrinking());
        }

        

    }

    //Movement
    void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            CreateDust();
        } else if(!isGrounded && doubleJump == true && jumpTotal > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpTotal = 0;
            CreateDust();
        }
    }
    void CheckGrounded()
    {
        if (Physics2D.OverlapCircle(feet.position, 0.25f, groundLayer))
        {
            isGrounded = true;
            jumpTotal = 1;
            jumpCoolDown = Time.time + 0.2f;
        }
        else if (Time.time < jumpCoolDown)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    //Sprites and Animation
    void FlipSprite()
    {
        if (mx < 0)
        {
            sprite.flipX = true;
            
        }
        else if (mx > 0)
        {
            sprite.flipX = false;
            
        }
    }
    void WalkingAnim()
    {
        if (mx != 0)
        {
            spriteAnims.SetBool("isWalking", true);
            
        }
        else
        {
            spriteAnims.SetBool("isWalking", false);
        }
    }
    void StopWalking() //This says not used but do not delete it is used in another script =)
    {
        spriteAnims.SetBool("isWalking", false);
    }


    //Dash
    void DashDirection()
    {
        if (mx >= 0)
        {
            
            dashingpower = 15;
        }
        else
        {
           
            dashingpower = -15;
        }
    }

    //Numerators
    IEnumerator shrinking()
    {
        isshrunk = true;
        yield return new WaitForSeconds(0.0001f);
        Vector2 objectScale = transform.localScale;
        transform.localScale = new Vector2(objectScale.x * 0.75f, objectScale.y * 0.75f);
        yield return new WaitForSeconds(0.3f);
        transform.localScale = new Vector2(objectScale.x * 0.5f, objectScale.y * 0.5f);
        jumpPower += 2f;   //Jump Boost for being tiny (You probably dont get the reference but its a super mario powerup)
        yield return new WaitForSeconds(3f);
        transform.localScale = new Vector2(objectScale.x * 1f, objectScale.y * 1f);
        jumpPower -= 2f;

        yield return new WaitForSeconds(2f); //Cooldown for shrink ability change if u want a diff cooldown
        isshrunk = false;
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        DashDirection();
        rb.velocity = new Vector2(transform.localScale.x * dashingpower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
      
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }

    void CreateDust()
    {
        Dust.Play();
    }
}
