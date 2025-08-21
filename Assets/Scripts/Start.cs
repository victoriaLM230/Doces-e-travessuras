using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Nome da cena do jogo que será carregada
    public string gameSceneName = "GameScene";

    // Função para ser chamada pelo botão
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}