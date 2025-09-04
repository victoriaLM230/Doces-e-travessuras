using UnityEngine;

public class MoveSabrina : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade = 5f;
    public Transform checagemChao;
    public float raioChao = 0.2f;
    public LayerMask camadaChao;


    private float horizontal;
    private Rigidbody2D rb;
    private bool estaNoChao;
    public bool PodeMexer = true;


    [Header("Som de Movimento")]
    public AudioSource somMovimento;  // arraste o AudioSource no Inspector
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //animação
        if (horizontal != 0)
        {
            animator.Play("walk");

        }

        else

        {
            animator.Play("idle");


        }
        if (horizontal < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (horizontal > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        estaNoChao = Physics2D.OverlapCircle(checagemChao.position, raioChao, camadaChao);


        horizontal = Input.GetAxisRaw("Horizontal");


        rb.linearVelocity = new Vector2(horizontal * velocidade, rb.linearVelocity.y);
        print(horizontal);
   


    }
}