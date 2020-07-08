using System;
using System.Security.Cryptography.X509Certificates;

namespace Segments
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' });
            int n = int.Parse(split[0]);
            int a = int.Parse(split[1]);
            int b = int.Parse(split[2]);
            int c = int.Parse(split[3]);
            char[] segment = new char[n + 1];
            for (int i = 0; i < segment.Length; i+=a)
            {
                segment[i] = '#';
            }
            for(int j = segment.Length - 1; j >= 0; j-=b)
            {
                segment[j] = '#';
            }
            for(int k = 0; k < segment.Length; k++)
            {
                if (segment[k] != '#')
                {
                    segment[k] = '0';
                }
            }
            int counter = 0;
            for (int l = 0; l < segment.Length; l++)
            {
                if(l+c < segment.Length)
                {
                    if (segment[l] == segment[l + c])
                    {
                        l = l + c-1;
                    }
                    else counter++;
                }
                else if( l+c >= segment.Length)
                {
                    if(segment.Length - 1 - l < c)
                    {
                        counter += segment.Length - 1 - l;
                        
                    }
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
