using System;
using System.Collections.Generic;

using Microsoft.VisualBasic;

public class Robot
{
    private static readonly List<string> NameList = new();
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            NameList.Add(value);
            _name = value;
        }
    }

    public Robot() => Name = GetUniqueName();


    private string GetUniqueName()
    {
        var rand = new Random();
        var newName = "";


        while (NameList.Contains(newName) || newName == "")
        {
            newName = RandomLetters(2) + rand.Next(101, 998);
        }

        return newName;
    }


    /// <summary>
    /// Random letters generator.
    /// </summary>
    /// <param name="lettersNumber">number of letters to generate</param>
    /// <returns> Uppercase common letters from A-Z </returns>
    public string RandomLetters(int lettersNumber)
    {
        var rand = new Random();

        var randLetters = "";

        for (var ctr = 0; ctr < lettersNumber; ctr++)
        {
            //decoding ascii values from A-Z (65-90)
            randLetters += Convert.ToChar(rand.Next(65, 91));
        }

        return randLetters.ToUpper();
    }

    public void Reset()
    {
        NameList.Remove(Name);
        Name = GetUniqueName();
    }
}