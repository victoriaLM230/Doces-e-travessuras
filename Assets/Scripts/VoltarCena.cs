using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarCena : MonoBehaviour
{
    // Nome da cena do jogo que será carregada
    public string gameSceneName = "jesus";

    // Função para ser chamada pelo botão
    public void butomcreditos()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}