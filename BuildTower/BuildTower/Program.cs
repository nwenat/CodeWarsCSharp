namespace BuildTower
{
    class Program
    {
        static void Main(string[] args)
        {
            TowerBuilder(6);
        }

        public static string[] TowerBuilder(int nFloors)
        {
            string[] output = new string[nFloors];
            int stars = 1;
            int spaces = nFloors - 1;

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = string.Concat(new string(' ', spaces), new string('*', stars), new string(' ', spaces));
                stars += 2;
                spaces--;
            }
            return output;
        }
    }
}
