public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Create an array to hold the multiples
        double[] multiples = new double[length];

        // Loop through the array length and calculate each multiple
        for (int i = 0; i < length; i++)
        {
            // Calculate each multiple (number * (i + 1)) and store it in the array
            multiples[i] = number * (i + 1);
        }

        // Return the filled array of multiples
        return multiples;
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Check to see if the number given is within range or equal to the length of the list
        if (amount == 0 || amount == data.Count)
        {
            return;
        }

        // Use modulo to normalize the amount given
        amount = amount % data.Count;

        // Make a temp array
        int[] temp = new int[data.Count];

        // Move the amount elements to the beginning of the list
        for (int i = 0; i < amount; i++)
        {
            temp[i] = data[data.Count - amount + i];
        }

        // Move remaining elements at the end of the list
        for (int i = 0; i < data.Count - amount; i++)
        {
            temp[amount + i] = data[i];
        }

        // Replace original list with temp array
        for (int i = 0; i < data.Count; i++)
        {
            data[i] = temp[i];
        }
    }
}
