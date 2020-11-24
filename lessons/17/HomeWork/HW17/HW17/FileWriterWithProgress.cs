using System;
using System.IO;

namespace HW17
{
    public class FileWriterWithProgress
    {
        public event EventHandler<Performed> WritingPerformed;
        public event EventHandler<Completed> WritingCompleted;

        public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {
            using (FileStream fs = File.OpenWrite(fileName))
            {
                for (int i = 0; i <= data.Length; i++)
                {
                    if (i != 0 && i % (GetNumber(data, percentageToFireEvent)) == 0)
                    {
                        fs.Write(data, i - (GetNumber(data, percentageToFireEvent)), (GetNumber(data, percentageToFireEvent)));
                        WritingPerformed?.Invoke(this, new Performed($"{fileName}", data, i / 100));
                    }
                }
                WritingCompleted?.Invoke(this, new Completed("Writing Complited!"));
            }
        }
        public static int GetNumber(byte[] data, float percentageToFireEvent)
        {
            return (int)(data.Length * percentageToFireEvent / 1.0);
        }
    }
}
