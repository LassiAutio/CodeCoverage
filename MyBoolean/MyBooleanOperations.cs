namespace MyBoolean
{
    public static class MyBooleanOperations
    {
        public static bool Xor(bool a, bool b)
        {
            if (a == b)
                return false;
            else
                return true;
        }
    }
}
