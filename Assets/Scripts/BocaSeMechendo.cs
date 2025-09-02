using UnityEngine;

public class BocaSeMechendo : MonoBehaviour
{
    public Sprite[] quadros; // quadros extraídos do sprite sheet
    public float velocidade = 0.1f; // tempo entre frames
    public bool falando = false;

    private SpriteRenderer sr;
    private int indice = 0;
    private float tempo = 0f;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!falando) return;

        tempo += Time.deltaTime;
        if (tempo >= velocidade)
        {
            indice = (indice + 1) % quadros.Length;
            sr.sprite = quadros[indice];
            tempo = 0f;
        }
    }
}

