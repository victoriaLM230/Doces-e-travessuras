using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteragirComItemDeDentroDaCabana : MonoBehaviour
{
    public GameObject painelDialogo;

    public TMP_Text textoDialogo;

    public GameObject Item;
    public string[] falas; 

    public float tempoEntreLetras = 0.03f;

    private bool jogadorPerto = false;

    private bool dialogoAtivo = false;

    private int indiceFala = 0;

    private bool podeAvancar = false;



    void Update()

    {

        if (jogadorPerto && Input.GetKeyDown(KeyCode.E) && !dialogoAtivo)

        {

            IniciarDialogo();

        }

        else if (dialogoAtivo && Input.GetKeyDown(KeyCode.E) && podeAvancar)

        {

            ProximaFala();

        }

    }



    void IniciarDialogo()

    {

        dialogoAtivo = true;

        indiceFala = 0;

        painelDialogo.SetActive(true);

        StartCoroutine(MostrarFala(falas[indiceFala]));

    }



    void ProximaFala()

    {

        indiceFala++;

        if (indiceFala < falas.Length)

        {

            StartCoroutine(MostrarFala(falas[indiceFala]));

        }

        else

        {

            // Fim do diálogo 

            painelDialogo.SetActive(false);

            dialogoAtivo = false;

            Destroy(Item);


        }

    }



    System.Collections.IEnumerator MostrarFala(string fala)

    {

        podeAvancar = false;

        textoDialogo.text = "";

        foreach (char letra in fala.ToCharArray())

        {

            textoDialogo.text += letra;

            yield return new WaitForSeconds(tempoEntreLetras);

        }

        podeAvancar = true;

    }



    void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))

        {

            jogadorPerto = true;

        }

    }



    void OnTriggerExit2D(Collider2D other)

    {

        if (other.CompareTag("Player"))

        {

            jogadorPerto = false;

        }

    }

}
