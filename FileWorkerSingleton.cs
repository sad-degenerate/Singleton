using System;
using System.IO;

namespace Singleton
{
    public sealed class FileWorkerSingleton
    {
        private static readonly Lazy<FileWorkerSingleton> instance = new Lazy<FileWorkerSingleton>(() => new FileWorkerSingleton());

        public static FileWorkerSingleton Instance { get { return instance.Value; } }

        public string Path { get; }
        public string Text { get; private set; }

        private FileWorkerSingleton()
        {
            Path = "test2.txt";
            ReadTextFromFile();
        }

        public void WriteText(string text)
        {
            Text += text;
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