using TMPro;
using UnityEngine;

public class GerenciadorDeDialogo : MonoBehaviour
{
    public GameObject painelDialogo;
    public TextMeshProUGUI textoNPC;
    public TextMeshProUGUI textoJogador;
    public GameObject painelEscolhas;
    public string[] falasNPC;
    public string[] falasJogador;
    public GameObject npcBruxa;
    private int indiceFala = 0;
    public bool dialogoAtivo = false;
    private bool esperandoEscolha = false;
    void Start()
    {
        painelDialogo.SetActive(false);
        painelEscolhas.SetActive(false);

    }

    void Update()
    {
        if (dialogoAtivo && !esperandoEscolha && Input.GetKeyDown(KeyCode.Space))
        {
            AvancarFala();
        }
    }

    public void IniciarDialogo()
    {
        if (falasNPC.Length == 0 || falasJogador.Length == 0) return;

        indiceFala = 0;
        painelDialogo.SetActive(true); // ATIVA o painel (corrigido)
        AtualizarFalas();
        dialogoAtivo = true;

        // Aqui você desativa o movimento do personagem
        GameObject jogador = GameObject.FindGameObjectWithTag("Player");
        if (jogador != null)
        {
            jogador.GetComponent<MoveSabrina>().PodeMexer = false; // Exemplo
        }
    }

    void AvancarFala()
    {
        indiceFala++;

        if (indiceFala < falasNPC.Length && indiceFala < falasJogador.Length)
        {
            AtualizarFalas();

            if (indiceFala == falasNPC.Length - 1)
            {
                esperandoEscolha = true;
                Invoke(nameof(MostrarEscolhas), 0.5f);
            }
        }
        else
        {
            FecharDialogo();
        }
    }

    void AtualizarFalas()
    {
        textoNPC.text = falasNPC[indiceFala];
        textoJogador.text = falasJogador[indiceFala];
    }

    void MostrarEscolhas()
    {
        painelEscolhas.SetActive(true);
    }



    public void FecharDialogo()
    {
        painelDialogo.SetActive(false);
        dialogoAtivo = false;
        

        // Faz a bruxa desaparecer após o diálogo
        if (npcBruxa != null)
        {
            npcBruxa.SetActive(false); // Ou: Destroy(npcBruxa);
        }
    }

}
