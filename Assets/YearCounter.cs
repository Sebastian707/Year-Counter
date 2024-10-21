using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YearCounter : MonoBehaviour
{
    public int MainAge = 24;
    public int CurrentYear = 2024;
    public int AddYear = 5; 
    public string MainName = "John";

    private int originalAge;
    private int originalYear;

    void Start()
    {
        originalAge = MainAge;
        originalYear = CurrentYear;

        Debug.Log(MainName + " is currently " + MainAge + " years old, in the year " + CurrentYear);

        AdditionYear(1); 
        Debug.Log("After adding 1 year: " + MainName + " is " + MainAge + " and the year is " + CurrentYear);

        AdditionYear(); 
        Debug.Log("After adding " + AddYear + " years to the original values: " + MainName + " will be " + MainAge + " and the year will be " + CurrentYear);
    }

    public void AdditionYear()
    {
        MainAge = originalAge + AddYear;
        CurrentYear = originalYear + AddYear;
    }

    public void AdditionYear(int yearsToAdd)
    {
        MainAge += yearsToAdd;
        CurrentYear += yearsToAdd;
    }

}