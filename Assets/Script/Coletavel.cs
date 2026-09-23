using JetBrains.Annotations;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int valor = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GerenciadorDeJogo.instancia.AdicionarPontos(valor);
            Destroy(gameObject);
        }
    }
}