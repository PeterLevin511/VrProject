using TMPro;
using UnityEngine;

public class CalculatorScript : MonoBehaviour {
    [SerializeField] private TMP_InputField inputField1;
    [SerializeField] private TMP_InputField inputField2;
    [SerializeField] private TMP_Text outputText;    

    public void OnButtonMinos() {
        float value1 = ReadloadFromInputFiald(inputField1); 
        float value2 = ReadloadFromInputFiald(inputField2);
        outputText.text = (value1 - value2).ToString();
    }

    public void OnButtonPlus() {
    }

    public void OnButtonPuls() {
        float value1 = ReadloadFromInputFiald(inputField1); 
        float value2 = ReadloadFromInputFiald(inputField2);
        outputText.text = (value1 - value2).ToString();
    }
    private float ReadloadFromInputFiald(TMP_InputField inputField) {
        string str = inputField.text;
        if (str !=null && str.Length > 0) { 
            if (float.TryParse(str, out float floatValue)) {
                return floatValue;
            }
        }
        return 0;
    }
}