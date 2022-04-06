using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonagem : MonoBehaviour
{
    public float moveVel = 50f;
    public float forcaPulo = 10f;
    public string nome;

    // componente que controla a física 
    Rigidbody rb;

    // guarda x e y
    Vector2 inputVector;
    bool inputPulo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        inputPulo = Input.GetKeyDown( KeyCode.Space );
    }

    // sempre ocorre 50 vezes por segundo
    void FixedUpdate() 
    {
        // condição que checa se o jogador
        // apertou um input
        if(inputPulo)
        {
            // escolhendo a direção do impulso
            Vector3 Pulodir = Vector3.up * forcaPulo;
            // aplicando uma força na direção escolhida
            rb.AddForce( Pulodir, ForceMode.Impulse );
        } 

        // vetores são posições e direções
        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);
        rb.AddForce(moveDir * moveVel, ForceMode.Force);

    }



}
