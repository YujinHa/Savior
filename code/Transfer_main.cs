using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transfer_main : MonoBehaviour
{

    public string Stage1;

    void Start()
    {

    }

    public void Click()
    {
            SceneManager.LoadScene(Stage1);
    }
}
