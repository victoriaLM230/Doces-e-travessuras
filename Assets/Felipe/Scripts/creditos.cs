using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour
{
    // Nome da cena do jogo que ser� carregada
    public string gameSceneName = "creditos";

    // Fun��o para ser chamada pelo bot�o
    public void butomcreditos()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}