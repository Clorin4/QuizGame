using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonActFacil : MonoBehaviour
{

    //PlayerPrefs.SetInt()
    //PlayerPrefs.SetFloat()
    //PlayerPrefs.SetString()

    


    public GameObject[] objetospanels;
    private List<int> panelIndexes;
    public GameObject pregunta00;
    public GameObject pregunta01;
    public GameObject pregunta02;
    public GameObject pregunta03;
    public GameObject pregunta04;
    public GameObject pregunta05;
    public GameObject pregunta06;
    public GameObject pregunta07;
    public GameObject pregunta08;
    public GameObject pregunta09;
    public GameObject FinalPanel;

    public GameObject Respuesta00;
    public GameObject Respuesta01;
    public GameObject Respuesta02;
    public GameObject Respuesta03;

    public GameObject hintButton;
    public GameObject TerminarBt;
    public TMP_Text Score;

    int myScore;
    private void Start()
    {
        int myScore = PlayerPrefs.GetInt("MyScore");
        FinalPanel.SetActive(false);


        panelIndexes = new List<int>();
        for (int i = 0; i < objetospanels.Length; i++)
        {
            //objetospanels[i].SetActive(false);
            panelIndexes.Add(i);
        }

        objetospanels = new GameObject[10];  //cant d preg
        objetospanels[0] = pregunta00;
        objetospanels[1] = pregunta01;
        objetospanels[2] = pregunta02;
        objetospanels[3] = pregunta03;
        objetospanels[4] = pregunta04;
        objetospanels[5] = pregunta05;
        objetospanels[6] = pregunta06;
        objetospanels[7] = pregunta07;
        objetospanels[8] = pregunta08;
        objetospanels[9] = pregunta09; 

    }

    public void Quitarpanels()
    {
        pregunta00.SetActive(false);
        pregunta01.SetActive(false);
        pregunta02.SetActive(false);
        pregunta03.SetActive(false);
        pregunta04.SetActive(false);
        pregunta05.SetActive(false);
        pregunta06.SetActive(false);
        pregunta07.SetActive(false);
        pregunta08.SetActive(false);
        pregunta09.SetActive(false); 
        
    }

    public void PregRandom()
    {
        int indiceAleatorio = Random.Range(0, panelIndexes.Count);
        GameObject objetoAleatorio = objetospanels[panelIndexes[indiceAleatorio]];
        objetoAleatorio.SetActive(true);
        //Invoke("PregRandom", 2f);
        panelIndexes.RemoveAt(indiceAleatorio);
        

        if (panelIndexes.Count == 0)
        {
            pregunta00.SetActive(false);
            pregunta01.SetActive(false);
            pregunta02.SetActive(false);
            pregunta03.SetActive(false);
            pregunta04.SetActive(false);
            pregunta05.SetActive(false);
            pregunta06.SetActive(false);
            pregunta07.SetActive(false);
            pregunta08.SetActive(false);
            pregunta09.SetActive(false); 
            FinalPanel.SetActive(true);
        }
        else
        {
            pregunta00.SetActive(false);
            pregunta01.SetActive(false);
            pregunta02.SetActive(false);
            pregunta03.SetActive(false);
            pregunta04.SetActive(false);
            pregunta05.SetActive(false);
            pregunta06.SetActive(false);
            pregunta07.SetActive(false);
            pregunta08.SetActive(false);
            pregunta09.SetActive(false);
            objetoAleatorio.SetActive(true);
            Invoke("PregRandom", 10f); // espera 10 segundos antes de mostrar el siguiente panel

        } 

    }

    public void HintButtonAct()
    {
        Respuesta01.SetActive(false);
        Respuesta03.SetActive(false);

        hintButton.SetActive(false);
    }

    public void ActivarHint()
    {
        int newIntScore = PlayerPrefs.GetInt("MyScore");
        if (newIntScore == 300)
        {
            hintButton.SetActive(true);

        }

        else hintButton.SetActive(false);

    }

    public void ResCorrecta()
    {
        myScore += 100;
        PlayerPrefs.SetInt("MyScore", myScore);
        PlayerPrefs.Save();

        ShowScore();
    }

    public void ResIncorrecta()
    {
        myScore -= 25;
        PlayerPrefs.SetInt("MyScore", myScore);
        PlayerPrefs.Save();

        ShowScore();
    }

    public void Finjuego()
    {
        pregunta00.SetActive(false);
        pregunta01.SetActive(false);
        pregunta02.SetActive(false);
        pregunta03.SetActive(false);
        pregunta04.SetActive(false);
        pregunta05.SetActive(false);
        pregunta06.SetActive(false);
        pregunta07.SetActive(false);
        pregunta08.SetActive(false);
        pregunta09.SetActive(false);
        FinalPanel.SetActive(true);
        TerminarBt.SetActive(false);
}

    public void ShowScore()
    {
        int newIntScore = PlayerPrefs.GetInt("MyScore");
        //Debug.Log("New Score: " + newIntScore);
        Score.text = newIntScore.ToString("0");
        
    }

    public void Update()
    {

        ActivarHint();

    }


}
