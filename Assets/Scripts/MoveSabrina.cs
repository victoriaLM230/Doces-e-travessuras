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
    public bool PodeMexer;

    void Start()

    {


        rb = GetComponent<Rigidbody2D>();


    }



    void Update()

    {

        // Verifica se est� no ch�o usando OverlapCircle 

        estaNoChao = Physics2D.OverlapCircle(checagemChao.position, raioChao, camadaChao);



        // Movimento horizontal 

        horizontal = Input.GetAxisRaw("Horizontal");


        rb.linearVelocity = new Vector2(horizontal * velocidade, rb.linearVelocity.y);

   

    }
}

