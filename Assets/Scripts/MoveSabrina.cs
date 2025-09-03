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
        // Verifica se está no chão usando OverlapCircle 
        estaNoChao = Physics2D.OverlapCircle(checagemChao.position, raioChao, camadaChao);

        // Movimento horizontal 
        horizontal = Input.GetAxisRaw("Horizontal");
       
       

        if (PodeMexer)
        {
            //Substituído .velocity por .linearVelocity
           rb.linearVelocity = new Vector2(horizontal * velocidade, rb.linearVelocity.y);
            //Substituído .velocity por .linearVelocity
           rb.linearVelocity = new Vector2(horizontal * velocidade, rb.linearVelocity.y);
        }

        // Som de movimento (somente se pressionando A ou D)
        if (estaNoChao && horizontal != 0)
        {
            if (!somMovimento.isPlaying)
            {
                somMovimento.Play();
            }
            print("ola");
            animator.Play("walk");
        }
        else
        {
            if (somMovimento.isPlaying)
            {
                somMovimento.Stop();
            }
            print("tchau");
            animator.Play("idle");
        }
        print(horizontal);
    }
}