using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorNumerosRandom : Pai
{
    // Start is called before the first frame update
    //public InputField numero;
    public GameObject prefabButton;
    public RectTransform ParentPanel;
    private StaticValue info;


    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindObjectOfType<StaticValue>();
        gerarNumeros(info.getMetodo());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void selectionSort(Button[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (int.Parse(arr[j].GetComponentInChildren<Text>().text) < int.Parse(arr[min_idx].GetComponentInChildren<Text>().text))
                    min_idx = j;
            }

            int temp = int.Parse(arr[min_idx].GetComponentInChildren<Text>().text);
            arr[min_idx].GetComponentInChildren<Text>().text = arr[i].GetComponentInChildren<Text>().text;
            arr[i].GetComponentInChildren<Text>().text = temp.ToString();
            
        }
    }

    public void gerarNumeros(string metodo)
    {
        //int qtd = int.Parse(numero.text);
        int qtd = info.getQtd();

        MyAwesomeCreator(qtd, metodo);

    }


    void MyAwesomeCreator(int qtd, string metodo)
    {
        string valor;
        int inicio, fim, i = 0, situacao = 0;
        int[] numeros = new int[qtd];

        inicio = info.getInicio();
        fim = info.getFim();

        if(metodo == "btnSequencial")
        {
            while(i < qtd)
            {
                valor = (Random.Range(inicio, fim + 1).ToString());
                for(int j = 0; j < i; j++)
                {
                    if (numeros[j] == int.Parse(valor))
                    {
                        situacao = 1;
                    }
                }

                if(situacao == 0)
                {
                    numeros[i] = int.Parse(valor);
                    GameObject goButton = (GameObject)Instantiate(prefabButton);
                    Text valorBtn = goButton.GetComponentInChildren<Text>();
                    //valor = (Random.Range(inicio, fim + 1).ToString());

                    valorBtn.text = valor;
                    goButton.transform.SetParent(ParentPanel, false);

                    i++;
                }
                
                situacao = 0;
            }
        }

        if (metodo == "btnBinaria")
        {
            while (i < qtd)
            {
                valor = (Random.Range(inicio, fim + 1).ToString());
                for (int j = 0; j < i; j++)
                {
                    if (numeros[j] == int.Parse(valor))
                    {
                        situacao = 1;
                    }
                }

                if (situacao == 0)
                {
                    numeros[i] = int.Parse(valor);
                    GameObject goButton = (GameObject)Instantiate(prefabButton);
                    Text valorBtn = goButton.GetComponentInChildren<Text>();
                    //valor = (Random.Range(inicio, fim + 1).ToString());

                    valorBtn.text = valor;
                    goButton.transform.SetParent(ParentPanel, false);

                    i++;
                }

                situacao = 0;
            }

            selectionSort(pegaArray(ParentPanel));
        }

        /*for (int i = 0; i < qtd; ++i)
        {
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            Text valorBtn = goButton.GetComponentInChildren<Text>();
            valor = (Random.Range(inicio, fim + 1).ToString());
            
            valorBtn.text = valor;
            goButton.transform.SetParent(ParentPanel, false);
        }
        */
    }
}
