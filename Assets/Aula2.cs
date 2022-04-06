using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula2 : MonoBehaviour
{
    // exemplo
    int ataque = 50;
    float altura = 1.84f;
    double altura2 = 1.84;
    string nome = "Enrico Cavicchioli";
    char til = '~';

    Rigidbody meuRb;
    Input meuInput;
    Animator meuAnimator;
    Animation minhaAnimation;


    // start ocorre UMA VEZ ao iniciar o jogo
    void Start()
    {
        // um código aqui
    }

    // update ocorre uma vez por frame (30 - 300 fps)
    void Update()
    {
        // game loop
        /*
        Exemplos de coisas que vão no update
            gravidade/física
            detecção de input
            animações
            pontuação
            
        */
    }
}
