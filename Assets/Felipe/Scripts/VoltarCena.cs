using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarCena : MonoBehaviour
{
    // Nome da cena do jogo que ser� carregada
    public string gameSceneName = "jesus";

    // Fun��o para ser chamada pelo bot�o
    public void butomcreditos()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}