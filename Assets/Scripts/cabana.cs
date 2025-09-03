using UnityEngine;
using UnityEngine.SceneManagement;

public class cabana : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "GameScene";

    public void coiso()
    {
        print("ooooo");
        SceneManager.LoadScene(gameSceneName);
    }
}