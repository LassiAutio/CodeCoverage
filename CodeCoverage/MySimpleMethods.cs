namespace CodeCoverage
{
    public static class MySimpleMethods
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static bool Xor(bool a, bool b)
        {
            if (a == b)
                return false;
            else
                return true;
        }
    }
}
