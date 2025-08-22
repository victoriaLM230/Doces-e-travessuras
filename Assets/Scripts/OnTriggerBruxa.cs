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
            jogadorNaArea = false; // Evita recomeçar o diálogo enquanto estiver dentro
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorNaArea = true;
            // Aqui você pode mostrar um aviso tipo: "Pressione E para falar"
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorNaArea = false;
            // Aqui você pode esconder o aviso
        }
    }
}