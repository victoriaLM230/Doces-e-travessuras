using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "menu";

    public void Botaomenu()
    {
        SceneManager.LoadScene(gameSceneName);
    }




}