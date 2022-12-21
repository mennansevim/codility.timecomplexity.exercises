namespace TimeComplexity
{
    public class BinaryGap
    {
        public static int Solve(int val)
        {
            // 1001
            var binary = Convert.ToString(val, 2);
            var counter = 0;
            var maxCount = 0;
            var started = false;
        
            foreach (char c in binary)
            {
                switch (c)
                {
                    case '1':
                    {
                        if (started)
                        {
                            if (counter > maxCount)
                            {
                                maxCount = counter;
                            }
                        }

                        counter = 0;
                        started = true;
                        break;
                    }
                    case '0':
                        counter++;
                        break;
                }
            }

            return maxCount;
        }
    }
}