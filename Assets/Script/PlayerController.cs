using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    [Header("Teclas de movimento")]
    public KeyCode teclaCima = KeyCode.W;
    public KeyCode teclaBaixo = KeyCode.S;
    public KeyCode teclaEsquerda = KeyCode.A;
    public KeyCode teclaDireita = KeyCode.D;

    private Rigidbody rb;
    // Variável privada que vai guardar a referência ao componente
    // Rigidbody do objeto. "private" porque não precisa aparecer
    // no Inspector é só uso interno do script.

    void Start()
    // Start() roda UMA ÚNICA VEZ, antes do primeiro Update(),
    // quando o objeto entra em cena. Ideal para preparar referências.
    {
        rb = GetComponent<Rigidbody>();
        // GetComponent<Rigidbody>() procura, no mesmo GameObject onde
        // este script está, um componente do tipo Rigidbody e guarda
        // a referência na variável "rb". Precisa que o objeto tenha
        // um Rigidbody adicionado no Inspector, senão dá erro (null).
    }

    void Update()
    {
        Vector3 direcao = Vector3.zero;

        if (Input.GetKey(teclaCima))
            direcao += Vector3.forward;
        if (Input.GetKey(teclaBaixo))
            direcao += Vector3.back;
        if (Input.GetKey(teclaEsquerda))
            direcao += Vector3.left;
        if (Input.GetKey(teclaDireita))
            direcao += Vector3.right;

        rb.AddForce(direcao.normalized * speed);
        // AddForce() aplica uma força física ao Rigidbody, empurrando
        // o objeto na direção indicada. É isso que faz a bola "rolar"
        // de verdade (com aceleração, inércia, atrito, colisões etc.),
        // em vez de simplesmente teleportar a cada frame como o
        // Translate fazia.
    }
}