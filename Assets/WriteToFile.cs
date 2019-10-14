using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteToFile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public GameObject prefabButton;
    public RectTransform ParentPanel;

    public void ordenado()
    {
        StartCoroutine(getTextFromFileOrdenado());
    }

    public void aleatorio()
    {
        StartCoroutine(getTextFromFile());
    }

[System.Obsolete]
    IEnumerator sendTextToFile()
    {
        bool successful = true;

        WWWForm form = new WWWForm();
        form.AddField("score", "1");
        WWW www = new WWW("http://localhost:9000/fromunity.php", form);

        yield return www;
        if(www.error != null)
        {
            successful = false;
        }
        else
        {
            Debug.Log(www.text);
            successful = true;
        }
    }

    IEnumerator getTextFromFileOrdenado()
    {
        bool successful = true;

        WWWForm form = new WWWForm();
        WWW www = new WWW("https://illegitimate-wardro.000webhostapp.com/tounityOrdenado.php", form);

        yield return www;
        if (www.error != null)
        {
            successful = false;
        }
        else
        {
            Debug.Log(www.text);
            successful = true;

            string myString = www.text;
            string[] myStringSplit = myString.Split(';');

            gerarNumeros(myStringSplit);

            
        }
    }

    IEnumerator getTextFromFile()
    {
        bool successful = true;

        WWWForm form = new WWWForm();
        WWW www = new WWW("https://illegitimate-wardro.000webhostapp.com/tounity.php", form);

        yield return www;
        if (www.error != null)
        {
            successful = false;
        }
        else
        {
            Debug.Log(www.text);
            successful = true;

            string myString = www.text;
            string[] myStringSplit = myString.Split(';');

            gerarNumeros(myStringSplit);

           
        }
    }

    public void gerarNumeros(string []myString)
    {
        
        for(int i = 0; i < myString.Length; ++i)
        {
            string valor = myString[i];
            MyAwesomeCreator(valor);
        }


    }

    void MyAwesomeCreator(string valor)
    {
        GameObject goButton = (GameObject)Instantiate(prefabButton);
        Text valorBtn = goButton.GetComponentInChildren<Text>();
        valorBtn.text = valor;
        goButton.transform.SetParent(ParentPanel, false);
    }


}
