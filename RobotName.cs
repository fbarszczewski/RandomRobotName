using System;
using System.Collections.Generic;

public class Robot
{
    public string Name { get; set; }
    private List<string> _nameList = new();

    public Robot()
    {
        Name = GetUniqueName();

    }

    private string GetUniqueName()
    {
        var rand = new Random();
        string newName="";


        while (_nameList.Contains(newName)|| newName=="")
        {
            newName = RandomLetters(2) + rand.Next(100, 999);
        }
        _nameList.Add(Name);

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
            randLetters += Convert.ToChar(rand.Next(64, 91));
        }

        return randLetters;
    }

    public void Reset()
    {
        _nameList.Remove(Name);
        Name = GetUniqueName();
    }
}