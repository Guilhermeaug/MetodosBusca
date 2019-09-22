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

    void OnGUI()
    {
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.fontSize = 25;
        if(GUI.Button(new Rect(10,10,450,80),"Send Information to File",buttonStyle))
        {
            StartCoroutine(sendTextToFile());
        }
        if (GUI.Button(new Rect(10, 100, 450, 80), "Get Information from File", buttonStyle))
        {
            StartCoroutine(getTextFromFile());
        }
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

            //Debug.Log(myStringSplit[0]);
            //Debug.Log(myStringSplit[1]);
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
