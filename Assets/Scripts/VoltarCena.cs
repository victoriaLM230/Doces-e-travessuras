using UnityEngine;
using UnityEngine.SceneManagement;

public class voltarcena : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "creditos";

    public void BotaoCreditos()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}