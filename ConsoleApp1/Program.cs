using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
        string message1 = Console.ReadLine();
        string message2 = Console.ReadLine();
        string message3 = Console.ReadLine();


        Console.Error.WriteLine("message 1 : " + message1);
        Console.Error.WriteLine("message 2 : {0}", message2);
        Console.Error.WriteLine($"message 3 : {message3}");

        byte[] m1 = Convert.FromHexString(message1);
        byte[] m2 = Convert.FromHexString(message2);
        byte[] m3 = Convert.FromHexString(message3);

        byte[] m0 = new byte[m1.Length];

        for (int i = 0; i < m0.Length; i++)
        {
            m0[i] = (byte)(m1[i] ^ m2[i] ^ m3[i]);
        }

        string hexString = Convert.ToHexString(m0);
        Console.Error.WriteLine($"message 0 : {hexString}");

        string message = Encoding.ASCII.GetString(m0);


        Console.WriteLine(message);
    }
}