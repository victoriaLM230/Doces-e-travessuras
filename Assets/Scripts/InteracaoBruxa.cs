using UnityEngine;

public class InteracaoBruxa : MonoBehaviour
{
    private bool jogadorPerto = false;
    public GerenciadorDeDialogo gerenciadorDialogo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            gerenciadorDialogo.IniciarDialogo();
        if  (jogadorPerto && !gerenciadorDialogo.dialogoAtivo && Input.GetKeyDown(KeyCode.E))
            {
                gerenciadorDialogo.IniciarDialogo();
                gerenciadorDialogo.npcBruxa = this.gameObject;
            }
    
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorPerto = true;
            Debug.Log("Jogador entrou na área da bruxa");
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorPerto = false;
        }
    }
}

