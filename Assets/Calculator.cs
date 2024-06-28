using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculator : MonoBehaviour
{

    public TMP_InputField firstNumber;
    public TMP_InputField secondNumber;
    public TextMeshProUGUI result;

    public void Add()
    {
        Tuple<double, double> numbers = getNumbersFromTextField();
        result.text = (numbers.Item1 + numbers.Item2).ToString("#.00");
    }

    public void Subtract()
    {
        Tuple<double, double> numbers = getNumbersFromTextField();
        result.text = (numbers.Item1 - numbers.Item2).ToString("#.00");
    }

    public void Divide()
    {
        Tuple<double, double> numbers = getNumbersFromTextField();
        if(numbers.Item2 == 0)
        {
            result.text = "Inifnite";
        }
        else
        {
            result.text = (numbers.Item1 / numbers.Item2).ToString("#.00");
        }
    }

    public void Multiply()
    {
        Tuple<double, double> numbers = getNumbersFromTextField();
        result.text = (numbers.Item1 * numbers.Item2).ToString("#.00");
    }

    Tuple<double, double> getNumbersFromTextField()
    {
         double fNumber;
         double sNumber;
        try
        {
            fNumber = double.Parse(firstNumber.text);
            sNumber = double.Parse(secondNumber.text);
        }
        catch(Exception e)
        {
            return Tuple.Create(0.0,0.0);
        }
        return Tuple.Create(fNumber,sNumber);
    }

}
