using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public TMP_InputField[] inputFields;
    public int custom1;
    public int custom2;

    public void CheckNumber()
    {
        if (int.TryParse(inputFields[0].text, out int number1))
        {
            custom1 = number1;
        }
        
        if (int.TryParse(inputFields[1].text, out int number2))
        {
            custom2 = number2;
        }
        
    }
}
