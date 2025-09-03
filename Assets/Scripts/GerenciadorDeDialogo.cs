using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GerenciadorDeDialogo : MonoBehaviour
{
    public GameObject painelDialogo;
    public TextMeshProUGUI textoNPC;
    public TextMeshProUGUI textoJogador;

    public GameObject painelEscolhas;
    public Button botaoBem;
    public Button botaoMal;

    public string[] falasNPC;
    public string[] falasJogador;

    public GameObject npcBruxa; // Refer�ncia ao GameObject da bruxa
    public BocaSeMechendo bocaAnimada; // ? Refer�ncia � boca animada

    private int indiceFala = 0;
    public bool dialogoAtivo = false;
    private bool esperandoEscolha = false;

    public int moralidade = 0; // Come�a neutro

    void Start()
    {
       // botaoBem.onClick.AddListener(EscolherBem);
       // botaoMal.onClick.AddListener(EscolherMal);
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
        painelDialogo.SetActive(true);
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

        if (bocaAnimada != null)
            bocaAnimada.falando = true;
    }

    void MostrarEscolhas()
    {
        painelEscolhas.SetActive(true);
    }

    void EscolherBem()
    {
        moralidade += 1;
        Debug.Log("Escolheu o bem. Moralidade: " + moralidade);
        ChecarCaminho();
    }

    void EscolherMal()
    {
        moralidade -= 1;
        Debug.Log("Escolheu o mal. Moralidade: " + moralidade);
        ChecarCaminho();
    }

    void ChecarCaminho()
    {
        painelEscolhas.SetActive(false);
        esperandoEscolha = false;

        if (moralidade < 0)
        {
            textoNPC.text = "Voc� sente a escurid�o crescendo...";
        }
        else
        {
            textoNPC.text = "A luz continua dentro de voc�.";
        }

        Invoke(nameof(FecharDialogo), 2f);
    }

    public void FecharDialogo()
    {
        painelDialogo.SetActive(false);
        dialogoAtivo = false;
        Time.timeScale = 1f;
        if (npcBruxa != null)
        {
            npcBruxa.SetActive(false); // Ou: Destroy(npcBruxa);
        }
    }
}
