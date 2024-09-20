using System;

namespace TinhTongCacSoTrongFileText
{
    class Program
    {
        static string sourceFilePath = @"C:\Users\admin\Documents\HocLapTrinh\LapTrinhGameUnity\CongTapCode\C#\BaiTapCodeGym\TinhTongCacSoTrongFileText\FileDuLieu.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Please input file path");
            string path = sourceFilePath;
            Console.WriteLine("File path: " + path);
            ReadTextFileExample example = new ReadTextFileExample();
            example.ReadTextFile(path);
        }
    }
}