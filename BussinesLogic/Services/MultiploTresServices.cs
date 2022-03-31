using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BussinesLogic.Services
{
    public class MultiploTresServices : IMultiploTresServices
    {
        public List<string> GetMultiploTres()
        {           
            List<string> result = new List<string>();            
            try
            { 
                string path = @"c:\temp\MyTest.txt";
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        string linea = sr.ReadLine();
                        char[] digits1 = linea.ToCharArray();

                        int sumNum = 0;
                        string sumNumCadena = "";
                        foreach (char c in digits1)
                        {
                            sumNum += int.Parse(c.ToString());                            
                        }

                        sumNumCadena = sumNum.ToString();
                        sumNum = 0;
                        char[] digits2 = sumNumCadena.ToCharArray();
                        foreach (char c in digits2)
                        {
                            sumNum += int.Parse(c.ToString());
                        }

                        if(sumNum == 3 || sumNum == 6 || sumNum == 9 || sumNum % 3 == 0)
                        {
                            result.Add("si");
                        }
                        else
                        {
                            result.Add("no");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                _ = ex.InnerException;
            }

            return result;
        }
    }
}
