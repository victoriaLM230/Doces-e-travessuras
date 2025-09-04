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
 

    private int indiceFala = 0;
    public bool dialogoAtivo = false;
    private bool esperandoEscolha = false;

    

    void Start()
    {
        //botaoBem.onClick.AddListener(EscolherBem);
        //botaoMal.onClick.AddListener(EscolherMal);
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
       


        if (npcBruxa != null)
        {
            npcBruxa.SetActive(false); // Ou: Destroy(npcBruxa);
        }
    }
}
