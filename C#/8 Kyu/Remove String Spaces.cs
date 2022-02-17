namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            input = input.Replace(" ",string.Empty);
            return input;
        }
    }
}
