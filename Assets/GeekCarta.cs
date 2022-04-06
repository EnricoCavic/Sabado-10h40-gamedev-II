using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nova carta", menuName = "ScriptableObj/GeeksCarta")]
public class GeekCarta : ScriptableObject
{
    public long ataque, defesa, vida, tamanhoDoSapato, custo, seguroDeVida, chavePix;
    public float IPTU;
    public string efeito, comidaFavorita, elemento, placaDoCarro, email;
}
