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
        Debug.Log("And after " + AddYear + " years " + MainName + " will be " + MainAge + " and the year will be " + CurrentYear);
    }
    /// <summary>
    /// Adds additional years to the counter
    /// </summary>
    public void AdditionYear()
    {
        MainAge = originalAge + AddYear;
        CurrentYear = originalYear + AddYear;
    }

    /// <summary>
    /// Adds year to the current age and year
    /// </summary>
    public void AdditionYear(int yearsToAdd)
    {
        MainAge += yearsToAdd;
        CurrentYear += yearsToAdd;
    }

}