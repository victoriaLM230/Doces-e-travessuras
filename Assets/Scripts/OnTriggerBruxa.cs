using UnityEngine;

public class OnTriggerBruxa : MonoBehaviour
{
    public GerenciadorDeDialogo gerenciadorDialogo;

    private bool jogadorNaArea = false;

    void Update()
    {
        if (jogadorNaArea && Input.GetKeyDown(KeyCode.E))
        {
            gerenciadorDialogo.IniciarDialogo();
            jogadorNaArea = false; // Evita recome�ar o di�logo enquanto estiver dentro
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorNaArea = true;
            // Aqui voc� pode mostrar um aviso tipo: "Pressione E para falar"
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorNaArea = false;
            // Aqui voc� pode esconder o aviso
        }
    }
}