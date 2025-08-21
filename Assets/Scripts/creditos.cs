using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour
{
    public string gameSceneName = "creditos";

    public void butomcreditos()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}