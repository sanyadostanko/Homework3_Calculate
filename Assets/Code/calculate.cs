using System;
using UnityEngine;

public enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}

public class CalculatorMain : MonoBehaviour
{
    [SerializeField] private float FirstNumber;  
    [SerializeField] private float SecondNumber; 

    public void TriggerOperation(Operation operation) 
    {
        try
        {

            float result = 0; 

            switch (operation)
            {
                case Operation.Add:
                    result = FirstNumber + SecondNumber;
                    break;
                case Operation.Subtract:
                    result = FirstNumber - SecondNumber;
                    break;
                case Operation.Multiply:
                    result = FirstNumber * SecondNumber;
                    break;
                case Operation.Divide:
                    if (SecondNumber != 0)
                    {
                        result = FirstNumber / SecondNumber;
                    }
                    else
                    {
                        displayError("Cannot divide by zero!");
                        return;
                    }
                    break;
                default:
                    displayError("Unknown operation!");
                    return;
            }

            Debug.Log("Result: " + result);
        }
        catch (System.Exception exception)
        {
            displayError();
            Debug.LogError("Error: " + exception.Message);
            throw exception;
        }
    }

    public void SetNumbers(float first, float second)
    {
        FirstNumber = first;
        SecondNumber = second;
    }

    private void displayError(string message = "Error")
    {
        Debug.LogError(message);
    }
}

/*
 Пример установки значений для переменных 
 public void OnCalculateButtonClicked()
{
    SetNumbers(5.0f, 3.0f); // Пример установки чисел
    TriggerOperation(Operation.Add); // Пример вызова операции сложения
}
 */



