
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField1;
    [SerializeField] private TMP_InputField inputField2;
    [SerializeField] private TMP_InputField outp;    

    public void OnButtonMinos() {
        float value1 = ReadloadFromInputFiald(InputFiel1); 
        float value2 = ReadloadFromInputFiald(InputFiel2);
        OutputText.text = (value1 - value2).ToString();
    }
}