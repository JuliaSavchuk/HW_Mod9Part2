namespace HW_Mod9Part2
{
    internal class Task1
    {
        public delegate (int, int, int) RainbowColorDelegate(string color);

        public static void Tas1()
        {
            RainbowColorDelegate getColorRGB = delegate (string color)
            {
                return color.ToLower() switch
                {
                    "red" => (255, 0, 0),
                    "orange" => (255, 165, 0),
                    "yellow" => (255, 255, 0),
                    "green" => (0, 128, 0),
                    "blue" => (0, 0, 255),
                    "indigo" => (75, 0, 130),
                    "violet" => (238, 130, 238),
                    _ => throw new ArgumentException("Invalid rainbow color")
                };
            };

            string color = "green";
            var rgb = getColorRGB(color);
            Console.WriteLine($"RGB value for {color} is ({rgb.Item1}, {rgb.Item2}, {rgb.Item3})");
        }
    }
}
