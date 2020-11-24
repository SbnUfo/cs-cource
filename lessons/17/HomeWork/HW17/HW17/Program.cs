using System;

namespace HW17
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileWriter = new FileWriterWithProgress();
            var write = new Result();
            byte[] data = new byte[10000];
            var random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)random.Next(255);
            }

            fileWriter.WritingPerformed += write.WriteResultData;
            fileWriter.WritingCompleted += write.WriteResultFinished;
            fileWriter.WriteBytes($"log.txt", data, 0.1f);
        }
    }
    public class Completed : EventArgs
    {
        public string Text { get; set; }
        public Completed(string text)
        {
            Text = text;
        }
    }
    public class Performed : EventArgs
    {
        public string FileName { get; set; }
        public byte[] Data { get; set; }
        public float PercentageToFireEvent { get; set; }
        public Performed(string fileName, byte[] data, float percentageToFireEvent)
        {
            FileName = fileName;
            Data = data;
            PercentageToFireEvent = percentageToFireEvent;
        }
    }
    public class Result
    {
        public void WriteResultData(object sender, Performed args)
        {
            Console.WriteLine($"{args.PercentageToFireEvent} % is done");
        }
        public void WriteResultFinished(object sender, Completed args)
        {
            Console.WriteLine(args.Text);
        }
    }
}
