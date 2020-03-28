using System.IO;

namespace Singleton
{
    public class FileWorker
    {
        public string Path { get; }
        public string Text { get; private set; }

        public FileWorker()
        {
            Path = "test.txt";
            ReadTextFromFile();
        }

        public void WriteText(string newText)
        {
            Text += newText;
        }

        public void Clear()
        {
            Text = "";
        }

        public void Save()
        {
            using (var writer = new StreamWriter(Path, false))
                writer.WriteLine(Text);
        }

        public void ReadTextFromFile()
        {
            if (!File.Exists(Path))
                Text = "";
            else
                using (var reader = new StreamReader(Path))
                    Text = reader.ReadToEnd();
        }
    }
}