using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Savename : MonoBehaviour
{

    public string myName;
    public TMP_Text textMesh;
    public TMP_InputField inputField;

    public void GuardarNombre()
    {
        string nombre = inputField.text;
        PlayerPrefs.SetString("nombre", nombre);
    }


    public void Start()
    {
        
        string nombre = PlayerPrefs.GetString("nombre");
        textMesh.text = nombre;
    }





}
