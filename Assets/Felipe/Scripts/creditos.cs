using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour
{
    // Nome da cena do jogo que será carregada
    public string gameSceneName = "creditos";

    // Função para ser chamada pelo botão
    public void butomcreditos()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}