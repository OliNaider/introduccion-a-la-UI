using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class saludoUIManager : MonoBehaviour
{
    public TextMeshProUGUI TxTSaludo;
    public TMP_InputField inputNombre;

    string nombreIngresado;

    // Start is called before the first frame update
    void Start()
    {
        TxTSaludo.text = "";


    }

   public void Saludar()
    {
        TxTSaludo.text = "Hola " + inputNombre.text;
    } 
}
