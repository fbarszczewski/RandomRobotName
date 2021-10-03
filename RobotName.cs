using System;
public class Robot
{
    public string Name { get; set; }

    public Robot()
    {
        var rand = new Random();
        Name = rand.Next(100,999).ToString();
    }

    
    /// <summary>
    /// Random letters generator.
    /// </summary>
    /// <param name="lettersNumber">number of letters to generate</param>
    /// <returns> Uppercase common letters from A-Z </returns>
    public string RandomLetters(int lettersNumber)
    {
        var rand = new Random();

        string randLetters = "";

        for (int ctr = 0; ctr <= lettersNumber; ctr++)
            randLetters += Convert.ToChar(rand.Next(65,90));

        return randLetters;
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}