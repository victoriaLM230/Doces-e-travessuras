using UnityEngine;
using UnityEngine.SceneManagement;
public class CabanaGame : MonoBehaviour
{
    private bool jogadorPerto = false;



    void Update()

    {

        if (jogadorPerto && Input.GetKeyDown(KeyCode.E))

        {

            // Troca de cena - voc� deve adicionar essa cena nas Build Settings 

            SceneManager.LoadScene("InteriorCabana");

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
