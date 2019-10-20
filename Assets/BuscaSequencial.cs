using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscaSequencial : Pai
{
    
    public RectTransform ParentPanel;
    public InputField alvo;
    private float tempo = 1;

    public void buscaSequencial()
    {
        StartCoroutine(sequentialSearch(pegaArray(ParentPanel),int.Parse(alvo.text)));
    }

    IEnumerator sequentialSearch(Button[] arr, int x)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            StartCoroutine(colorir(tempo, arr[i]));
            yield return new WaitForSecondsRealtime(tempo);
            if (int.Parse(arr[i].GetComponentInChildren<Text>().text) == x)
                yield break;

            StartCoroutine(excluir(tempo, arr[i]));
        }
        
    }
}
