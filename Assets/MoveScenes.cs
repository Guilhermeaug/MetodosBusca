using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes : MonoBehaviour
{
    public string level0;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(level0);
    }
}
