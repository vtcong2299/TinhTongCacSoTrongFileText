using System;
using System.Globalization;

namespace TinhTongCacSoTrongFileText
{
    public class ReadTextFileExample
    {
        public void ReadTextFile(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (!file.Exists)
                {
                    throw new FileNotFoundException();
                }
                StreamReader reader = new StreamReader(filePath);
                string? line = "";
                int sum = 0;
                //Console.WriteLine("Cac so trong file la: ");
                while ((line = reader.ReadLine()) != null)
                {   
                    Console.WriteLine(line);
                    int number= int.Parse(line);
                    sum += number;

                    // if (int.TryParse(line, out int number))
                    // {
                    //     Console.WriteLine(number);
                    //     sum += number;
                    // }    
                }
                reader.Close();
                Console.WriteLine("Total: " + sum);
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("File not found or invalid content");
            }
        }
    }
}