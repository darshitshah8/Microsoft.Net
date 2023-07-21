namespace HomeworkOverriding
{
    public class Marks 
    {
        public int Low { get; set; }
        public int High { get; set; }

        public override string ToString()
        {
            return $"{Low} {High}";
        }
    }
}
