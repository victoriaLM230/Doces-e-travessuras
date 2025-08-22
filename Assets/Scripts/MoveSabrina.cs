using UnityEngine;


public class MoveSabrina : MonoBehaviour
{
    

    [Header("Movimento")]

    public float velocidade = 5f;



    [Header("Pulo")]

    public float forcaPulo = 12f;

    public Transform checagemChao;

    public float raioChao = 0.2f;

    public LayerMask camadaChao;


    private float horizontal;
    private Rigidbody2D rb;

    private bool estaNoChao;



    void Start()

    {
        rb = GetComponent<Rigidbody2D>();
        print(rb);

    }



    void Update()

    {

        // Verifica se est� no ch�o usando OverlapCircle 

        estaNoChao = Physics2D.OverlapCircle(checagemChao.position, raioChao, camadaChao);



        // Movimento horizontal 

        horizontal = Input.GetAxisRaw("Horizontal");
        

        rb.linearVelocity = new Vector2(horizontal * velocidade, rb.linearVelocity.y);
        print(rb.linearVelocityX);


        // Pular 

        if (Input.GetButtonDown("Jump") && estaNoChao)

        {

            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);

        }

    }

    void OnDrawGizmosSelected()

    {

        // Desenha o c�rculo da checagem de ch�o no editor 

        if (checagemChao != null)

        {

            Gizmos.color = Color.green;

            Gizmos.DrawWireSphere(checagemChao.position, raioChao);

        }

    }

}

