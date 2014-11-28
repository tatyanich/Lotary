using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Bulls_And_Cows
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Combination : IBulls_And_Cows
    {
        int[] mas;
        public Combination()
        {
            mas = new int[3];
            Random r = new Random();
            mas[0] = r.Next(0, 9);
            mas[1] = r.Next(0, 9);
            mas[2] = r.Next(0, 9);
           
        }
        public string GetCombination()
        {
            return ToString();
        }
        public override string ToString()
        {
            return mas[0].ToString() + mas[1].ToString() + mas[2].ToString();
        }
        public Answer GetAnswer(string str)
        {
            //string result;
            Answer a = new Answer();

            int c = 0;
            //string [] number = str.Split(',');
           // int[] x = new int[3];
            //char[] x = str.ToCharArray(str, c); //str.ToArray(); ToIntArray(s, c);
           
            int[] ia = str.Split(',',' ').Select(n => Convert.ToInt32(n)).ToArray();

            for (int i = 0; i < 3; i++)
            {
                if (mas[i] == ia[i])
                 {
                     c++;
                   
                }
                if (c==0){
                    a.result = "You lose, you guessed nothing";
                }
                else if(c==1){
                    a.result = "You lose, you guessed only " + c + " number";
                }
                else if (c == 2)
                {
                    a.result = "Not bad, you guessed " + c + " number";
                }
                else 
                {
                    a.result = "My Congratulation you win!";
                }
                

            }
                //for (int j = 0; j < 4; j++)
                //{
                //    if (mas[i].ToString() == str.Substring(j, 1))
                //    {
                       
                //        if (i == j)
                //            a.Bulls++;
                //    }
                //}
            return a;
        }
    }
}
