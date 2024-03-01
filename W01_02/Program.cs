using W01_02;

namespace W02_01
{
    public class Program
    {
        //entry point
        static void Main(string[] args)
        {

            #region 01.Value Types

            #region 01.1 Primitive Types
            //Located stack section in Ram
            bool v1 = false;
            Console.WriteLine($"bool: {v1},   size:{sizeof(bool)}");

            byte v2 = 255;
            Console.WriteLine($"byte: {v2},   size:{sizeof(byte)}");

            char v3 = 'Ğ';
            Console.WriteLine($"char: {v3},   size:{sizeof(char)}");

            int v4 = 36;
            Console.WriteLine($"int: {v4},   size:{sizeof(int)}");

            long v5 = 429496729;
            Console.WriteLine($"long: {v5},   size:{sizeof(long)}");

            float v6 = 429496729.5f;
            Console.WriteLine($"float: {v6},   size:{sizeof(float)}");

            double v7 = 429496729.5f;
            Console.WriteLine($"double: {v7},   size:{sizeof(double)}");

            decimal v8 = 429496729.5M;
            Console.WriteLine($"decimal: {v8},   size:{sizeof(decimal)}");


            #endregion

            #region 01.2 Struct Types
            Student v9 = new Student();
            v9.id = 1;
            v9.income = 1.2;
            v9.name = "Ali";




            #endregion

            #region 01.3 Enum Types

            var cuma = WeekOfDays.Friday;

            //integer 
            //if (record.dayId == (int)WeekOfDays.Friday)
            //{
            //    //....
            //}


            #endregion


            #endregion
            
            #region 02.Reference Types
            //string/Immutable
            string name = "Aydın";


            //class 
            Course course = new Course()
            {
                Author = "Ali",
                Name = "C#",
                Title = "Prof"
            };

            //Interface
            IMessage std = new Course();

            #endregion

            #region 03.Pointer Types

            //unsafe
            //{
            //    int x = 10;
            //    int y = 20;
            //    int* ptr1 = &x;
            //    int* ptr2 = &y;
            //    Console.WriteLine((int)ptr1);
            //    Console.WriteLine((int)ptr2);
            //    Console.WriteLine(*ptr1);
            //    Console.WriteLine(*ptr2);
            //}

            #endregion

            #region 04.Static Types
            //static int xx = 0;
            //
            //Course c2= new Course();




            #endregion

            #region 05.Dynamic Types
            //runtime variables
            dynamic xxx = 3;
            //
            //
            //

            xxx = "Ali";
            //
            //
            //

            xxx = true;
            //
            //
            //

            //var axd = new List<Course>();

            //var axx = 5;

            //axx = "Ali";

            #endregion

        }
    }
}
