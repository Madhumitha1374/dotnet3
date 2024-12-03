using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadUsingThread
{
    internal class Program
    {
        static void DownloadFile(string url, string filePath)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, filePath);
            }
        }

        static void DownloadFileWithThread(string url, string filePath)
        {
            Thread thread = new Thread(() => DownloadFile(url, filePath));
            thread.Start();
            thread.Join(); // Wait for the thread to complete
        }

        static void Main(string[] args)
        {
            string[] urls = new string[]
            {
            "https://example.com/file1.zip",
            "https://example.com/file2.zip"
            };

            string[] filePaths = new string[]
            {
            "D:\\pv",
            "D:\\pv"
            };

            var threads = new Thread[urls.Length];
            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < urls.Length; i++)
            {
                int index = i; // Capture the index for the lambda
                threads[i] = new Thread(() => DownloadFile(urls[index], filePaths[index]));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join(); // Wait for all threads to complete
            }

            stopwatch.Stop();

            Console.WriteLine($"Time taken to download files: {stopwatch.Elapsed.TotalSeconds} seconds");
        }
    }
}
