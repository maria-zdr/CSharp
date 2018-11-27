//Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation.

using System;

class NumberToText
{
    static void Main()
    {
        Console.Write("Enter a number in the interval [0;999]: ");
        int number=int.Parse(Console.ReadLine());

        string[] uptonineteen = {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"};
        string[] tens = {"", "","Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety",};
      
        if (number < 20)
        {
            Console.WriteLine(uptonineteen[number]);
        }
        else if (number >= 20 && number < 100)
        {
          Console.WriteLine(((number % 10) == 0) ? tens[number / 10] : tens[number / 10] + " "+ uptonineteen[number % 10]);
        }
        else if (number >= 100 && number <= 999)
        {
            string  nuberText =  uptonineteen[number / 100] + " hundred " + ((((number % 100) / 10) > 1) ? tens[((number % 100) / 10)] + ((number % 10) > 0 ? " " + uptonineteen[(number % 10)] : "") : " " + uptonineteen[number % 100]);
            Console.WriteLine(nuberText);
        } 
    }
}

