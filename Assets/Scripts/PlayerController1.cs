using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] Animator animator;

    [SerializeField] private KeyCode rightKeyCode=KeyCode.D;
    [SerializeField] private KeyCode leftKeyCode=KeyCode.A;
    [SerializeField] private KeyCode jumpKeyCode=KeyCode.W;

    private bool canJump = true;
    float horizontalMovement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetFloat("Direction", 1.0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(jumpKeyCode) && canJump)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            canJump = false;
            animator.SetBool("IsJumping", true);
        }

        horizontalMovement = 0.0f;
        if (Input.GetKey(rightKeyCode))
        {
            horizontalMovement += 1.0f;
        }
        if (Input.GetKey(leftKeyCode))
        {
            horizontalMovement -= 1.0f;
        }
        horizontalMovement = horizontalMovement * speed;

        if (horizontalMovement < 0)
            animator.SetFloat("Direction", -1.0f);
        else if (horizontalMovement > 0)
            animator.SetFloat("Direction", 1.0f);

        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));
        animator.SetBool("IsFalling", (rb.linearVelocityY < -0.2f));
    }

    public void LandedOnGround()
    {
        animator.SetBool("IsJumping", false);
        animator.SetBool("IsFalling", false);
        canJump = true;
    }
}
