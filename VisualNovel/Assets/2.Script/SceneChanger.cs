using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void EpisodeSelect()
    {
        SceneManager.LoadScene("2)EpisodeSelect");
    }
    public void Episode_1()
    {
        SceneManager.LoadScene("3)Episode_1");
    }

    public void Note()
    {
        SceneManager.LoadScene("4)Note");
    }
    public void Store() 
    { 
        SceneManager.LoadScene("5)Store");
    }
    public void Main() 
    {
        SceneManager.LoadScene("1)Main");
    }
}


