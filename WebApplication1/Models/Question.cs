namespace IT_ELECTIVE_2_BSIT31A3_PREFINAL_EXAM_Billena_Dominic.Models
{
    public class Question
    {
        public int Number { get; set; }
        public string Text { get; set; } = "";
        public List<string> Choices { get; set; } = new();
        public string Answer { get; set; } = "";
    }
}