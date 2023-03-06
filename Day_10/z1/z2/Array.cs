using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
      public class Massiv
    {

            private string[] stroka;
            private int hInd;

            public Massiv(int Ind)
            {
                stroka = new string[Ind];
                for (int i = 0; i < Ind; i++)
                {
                    stroka[i] = "";
                }
                hInd = Ind;
            }
            public Massiv(string[] strok, int Ind)
            {
                stroka = new string[Ind];
                for (int i = 0; i < Ind; i++)
                {
                    stroka[i] = strok[i];
                }
                hInd = Ind;
            }

            public void ClWrite()
            {
                for (int i = 0; i < hInd; i++)
                {
                    if (stroka[i] != "")
                        Console.Write(stroka[i] + "  ");
                }
            }
            public string getString(int index)
            {
                string founded = null;
                if (index >= hInd || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    founded = stroka[index];
                }
                return founded; 
            }

            public void setString(int NumOfElement, string value)
            {
                if (NumOfElement >= hInd || NumOfElement < 0)
                { throw new IndexOutOfRangeException(); }
                else
                    stroka[NumOfElement] = value;
            }
          
            public static Massiv operator +(Massiv x, Massiv y)
            {
                string[] sc = new string[x.hInd + y.hInd];
                Array.Copy(x.stroka, sc, x.hInd); 
                Array.Copy(y.stroka, 0, sc, x.hInd, y.hInd);
                Massiv tmp1 = new Massiv(sc, x.hInd + y.hInd);
                return tmp1;
            }
          
            public static Massiv operator -(Massiv x, Massiv y)
            {
                string[] sc = new string[x.hInd + y.hInd];
                for (int i = 0; i < x.hInd; i++)
                {
                    for (int j = 0; j < y.hInd; j++)
                    {
                        if (x.stroka[i] == y.stroka[j])
                        {
                            y.stroka[j] = "";
                        }
                    }
                }


                Massiv tmp3 = new Massiv(sc, x.hInd + y.hInd);
                tmp3 = x + y;
                return tmp3;
            }
        }
}
