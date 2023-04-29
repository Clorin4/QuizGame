using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public GameObject Titulo;
    public GameObject Savename;
    public GameObject Dificultad;

    public void Start()
    {
        Titulo.SetActive(true);
        Savename.SetActive(false);
        Dificultad.SetActive(false);
      
    }

    public object OnClick { get; internal set; }

    public void CambiarPanel()
    {
        Titulo.SetActive(false);
        Savename.SetActive(true);
    }

    public void CambiarPanel2()
    {
        Savename.SetActive(false);
        Dificultad.SetActive(true);
    }

    public void ChangeSceneEZ()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeSceneMED()
    {
        SceneManager.LoadScene(2);
    }

    public void ChangeSceneDIF()
    {
        SceneManager.LoadScene(3);
    }
    public void ChangeMainScene()
    {
        SceneManager.LoadScene(0);
    }

}
