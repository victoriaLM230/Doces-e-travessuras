using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "Felipe";

    public void Botaoparamenu()
    {
        print("ooooo");
        SceneManager.LoadScene(gameSceneName);
    }
}