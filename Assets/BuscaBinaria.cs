using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscaBinaria : Pai
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public RectTransform ParentPanel;
    public InputField alvo;
    private float tempo = 3;

    public void buscaBinaria(int max)
    {
        StartCoroutine(binarySearch(pegaArray(ParentPanel),0,max,int.Parse(alvo.text)));
    }

    IEnumerator binarySearch(Button[] arr, int l, int r, int x)
    {
        if (r >= l)
        {
            int mid = l + (r - l) / 2;

            StartCoroutine(colorir(tempo, arr[mid]));
            yield return new WaitForSecondsRealtime(tempo);
            if (int.Parse(arr[mid].GetComponentInChildren<Text>().text) == x)
                yield break;

            
            if (int.Parse(arr[mid].GetComponentInChildren<Text>().text) > x)
            {
                for(int i = mid; i < arr.Length; ++i)
                {
                    StartCoroutine(excluir(tempo, arr[i]));
                }
                yield return new WaitForSecondsRealtime(tempo);

                StartCoroutine(binarySearch(arr, l, mid - 1, x));
                yield return new WaitForSecondsRealtime(1);
            }


           
            if (int.Parse(arr[mid].GetComponentInChildren<Text>().text) < x)
            {
                for (int i = mid; i >= 0; --i)
                {
                    StartCoroutine(excluir(tempo, arr[i]));
                }
                yield return new WaitForSecondsRealtime(tempo);

                StartCoroutine(binarySearch(arr, mid + 1, r, x));
                yield return new WaitForSecondsRealtime(1);
            }
                
        }
        
    }
}
