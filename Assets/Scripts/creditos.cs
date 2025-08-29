using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "creditos";

    public void BotaoCreditos()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}