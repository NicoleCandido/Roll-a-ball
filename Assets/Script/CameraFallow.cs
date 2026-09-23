using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    public Transform alvo; // Referência ao objeto que a câmera vai seguir
    public Vector3 deslocamento = new Vector3(0f, 5f, -10f);
    public float suavizacao = 3f; // Quanto mais baixo, mais suave será o movimento da câmera

    private void LateUpdate()
    {
        Vector3 posicaoDesejada = alvo.position + deslocamento;
        transform.position = Vector3.Lerp(transform.position, posicaoDesejada, suavizacao * Time.deltaTime);
        transform.LookAt(alvo); // Faz a câmera olhar para o alvo
    }
}
