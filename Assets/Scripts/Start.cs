using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Nome da cena do jogo que ser� carregada
    public string gameSceneName = "GameScene";

    // Fun��o para ser chamada pelo bot�o
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}