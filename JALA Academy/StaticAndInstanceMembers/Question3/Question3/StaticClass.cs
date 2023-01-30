namespace Question3
{
    public class StaticClass
    {
        private static int x = 100;

        private static  int y = 90;

        //private int sum = x + y;


        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public StaticClass()
        {
            x = 1000;
            y = 900;
            
        }

        static StaticClass()
        {
            int x = 7;

            int y = 10;
        }

    }
}