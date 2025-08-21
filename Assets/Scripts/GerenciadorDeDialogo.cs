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
    private bool dialogoAtivo = false;
    private bool esperandoEscolha = false;
    void Start()
    {

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
        painelDialogo.SetActive(false);
        AtualizarFalas();
        dialogoAtivo = true;

        Time.timeScale = 0f; // Pausa o jogo enquanto fala
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
        Time.timeScale = 1f;

        // Faz a bruxa desaparecer após o diálogo
        if (npcBruxa != null)
        {
            npcBruxa.SetActive(false); // Ou: Destroy(npcBruxa);
        }
    }

}
