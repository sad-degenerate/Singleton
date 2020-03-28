namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker1 = new FileWorker();
            var worker2 = new FileWorker();

            worker1.Clear();
            worker2.Clear();
            worker1.WriteText("Hello, world!\n");
            worker1.WriteText("Next line");
            worker2.WriteText("Hello, world!\n");
            worker2.WriteText("Next line");

            worker1.Save();
            worker2.Save();

            var workerSingleton1 = FileWorkerSingleton.Instance;
            var workerSingleton2 = FileWorkerSingleton.Instance;

            workerSingleton1.Clear();
            workerSingleton2.Clear();

            workerSingleton1.WriteText("Hello, world!\n");
            workerSingleton1.WriteText("Next line");
            workerSingleton2.WriteText("Hello, world!\n");
            workerSingleton2.WriteText("Next line");

            workerSingleton1.Save();
            workerSingleton2.Save();
        }
    }
}