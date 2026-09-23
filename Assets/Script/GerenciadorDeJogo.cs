using UnityEngine;
using TMPro;

public class GerenciadorDeJogo : MonoBehaviour
{
    public static GerenciadorDeJogo instancia;
    public TextMeshProUGUI textoPontuacao;

    private int pontuacao = 0;

    void Awake()
    {
        instancia = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AtualizarTexto();   
    }

    public void AdicionarPontos(int quantidade)
    {
        pontuacao += quantidade;
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        textoPontuacao.text = "Pontuação: " + pontuacao;
    }
}
