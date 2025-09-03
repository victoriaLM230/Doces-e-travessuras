using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptSwap : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool jogadorPerto = false;



    void Update()

    {

        if (jogadorPerto && Input.GetKeyDown(KeyCode.E))

        {
            SceneManager.LoadScene("FimDoJogo");

        }

    }



    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))

        {

            jogadorPerto = true;

            // Aqui voc� pode ativar um UI "Pressione E para entrar" 

        }

    }



    private void OnTriggerExit2D(Collider2D other)

    {

        if (other.CompareTag("Player"))

        {

            jogadorPerto = false;

            // Aqui voc� pode esconder o UI 

        }

    }
}

