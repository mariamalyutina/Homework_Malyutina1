using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks_Malyutina.Tests
{
    public static class TwoDArrayMock
    {
        public static int[,] GetMock(int caseNum)
        {
            int[,] result = new int[0,0];
            switch(caseNum)
            {
                case 1:
                    result = new int[0,0];
                    break;
                //case 2:
                //    result = new int[0,1];
                //    break; //лишний
                case 2:
                    result = new int[,] { { 1, 2, 3 }, 
                                          { -5, 6, 7 }, 
                                          { 8, 3, 18 } };
                    break;
                case 3:
                    result = new int[,] { { 1 }, 
                                          { 5}, 
                                          { 0} };
                    break;
                case 4:
                    result = new int[,] { { 0 }, { 0 }, { 0 } };
                    break;
                case 5:
                    result = new int[,] { { 1, 2, 3, 25 }, 
                                          { 5, 6, 7, 9 }, 
                                          { 8, 3, 18, 18 } };
                    break;
                case 6:
                    result = new int[,] { { -2, 2, 0 },
                                          { 5, 10, 7},
                                          { 8, 14, 18} };
                    break;
                case 7:
                    result = new int[,] { { 1, -5, 8 },
                                          { 2, 6, 3},
                                          { 3, 7, 18} };
                    break;
                case 8:
                    result = new int[,] { { 1, 5, 0 } };
                    break;
                case 9:
                    result = new int[,] { { 1 }, { 5 }, {0 } };
                    break;
                case 10:
                    result = new int[,] { { 1, 5, 8},
                                          { 2, 6, 3},
                                          { 3, 7, 18},
                                          { 25, 9, 18} };
                    break;

            }

            return result;
        }
    }
}
