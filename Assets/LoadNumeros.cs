using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNumeros : MonoBehaviour
{
    //private GeradorNumerosRandom gerador;
    private StaticValue info;
    private BuscaSequencial sequencial;
    private BuscaBinaria binaria;
    int escolhido;
    void Start()
    {
        //gerador = GameObject.FindObjectOfType<GeradorNumerosRandom>();
        info = GameObject.FindObjectOfType<StaticValue>();
        sequencial = GameObject.FindObjectOfType<BuscaSequencial>();
        binaria = GameObject.FindObjectOfType<BuscaBinaria>();

        //gerador.gerarNumeros();
        
        /*string metodo = info.getMetodo();

        if (metodo == "btnSequencial")
        {
            
            sequencial.buscaSequencial();

        }
        else if (metodo == "btnBinaria")
        {
            
            binaria.buscaBinaria(info.getQtd());

        }*/
        
    }

    public void iniciaMetodo(int escolhido)
    {
        string metodo = info.getMetodo();

        if (metodo == "btnSequencial")
        {

            sequencial.buscaSequencial();

        }
        else if (metodo == "btnBinaria")
        {

            binaria.buscaBinaria(info.getQtd());

        }
    }
    
    public void lerAlvo(string alvo)
    {
        escolhido = int.Parse(alvo);
        iniciaMetodo(escolhido);

    }



}
