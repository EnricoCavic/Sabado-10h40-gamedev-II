using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Interpretador : MonoBehaviour
{
    public GeekCarta carta;

    public Text ataque, defesa, vida,
    tamanhoDoSapato, custo, efeito,
    comidaFavorita, elemento, nome;


    public void MostrarCarta()
    {
        nome.text = carta.name;
        ataque.text = carta.ataque.ToString();
        defesa.text = carta.defesa.ToString();
        vida.text = carta.vida.ToString();
        tamanhoDoSapato.text = carta.tamanhoDoSapato.ToString();
        custo.text = carta.custo.ToString();
        efeito.text = carta.efeito;
        elemento.text = carta.elemento;
    }

}
