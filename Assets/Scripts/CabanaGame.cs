using UnityEngine;
using UnityEngine.SceneManagement;
public class CabanaGame : MonoBehaviour
{
    private bool jogadorPerto = false;



    void Update()

    {

        if (jogadorPerto && Input.GetKeyDown(KeyCode.E))

        {

            // Troca de cena - você deve adicionar essa cena nas Build Settings 

            SceneManager.LoadScene("InteriorCabana");

        }

    }



    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))

        {

            jogadorPerto = true;

            // Aqui você pode ativar um UI "Pressione E para entrar" 

        }

    }



    private void OnTriggerExit2D(Collider2D other)

    {

        if (other.CompareTag("Player"))

        {

            jogadorPerto = false;

            // Aqui você pode esconder o UI 

        }

    }
}
