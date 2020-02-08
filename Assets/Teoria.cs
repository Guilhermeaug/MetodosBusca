using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teoria : MonoBehaviour
{
    Text txt;
    private StaticValue info;

    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindObjectOfType<StaticValue>();
        txt = gameObject.GetComponent<Text>();
        //txt.text = "Teste";

        imprimeTexto(info.getMetodo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void imprimeTexto(string metodo)
    {
        txt.color = Color.white;
        if (metodo == "btnSequencial")
        {
            txt.text = "O método de busca sequencial começa no elemento mais à esquerda do vetor e" +
                " compara elemento a elemento se o valor do mesmo bate com o valor desejado.";

        }
        else if (metodo == "btnBinaria")
        {
            txt.text = "O método de busca binária busca um valor no array através de múltiplas divisões " +
                "do intervalo de pesquisa. Se o valor a ser procurado é menor que o elemento que está no meio do intervalo" +
                ", o intervalo é reduzido para a metade inferior. Caso contrário, o intervalo é reduzido para a metade superior. " +
                "Isso é realizado repetidamente até que o valor desejado seja encontrado.  ";

        }
    }


}
