using System;

namespace case9
{
    class Program
    {
        static void Main(string[] args)
        {
            var day =Int32.Parse(Console.ReadLine());

            var month =Int32.Parse(Console.ReadLine());
            int days =0;


            switch (month)
            
            {
             case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                 days = 31; break;
             case 4: case 6: case 9:case 11:
                 days = 30; break;
             case 2:
                 days = 28; break;
             default:
                 Console.WriteLine("Invalid month!");
                 return;
            }

            if (day > days)
                day += 1;
            else
            {
                day = 1;
                month += 1;
                if (month > 12)
                {

                    month = 1;


                }
                
                
                Console.WriteLine( day);
                Console.WriteLine(month);
                
                








































                
                    
            }
            
                
                    
            
            
            
            


        }
    }
}