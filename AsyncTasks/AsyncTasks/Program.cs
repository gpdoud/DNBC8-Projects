using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTasks {
    class Program {


        async Task<string> CallBcms() { 
            var url = "http://doudsystems.com/bcms/dsi/roles";
            var http = new HttpClient();
            var str = await http.GetStringAsync(url);
            return str;
        }

        void Method1Sync() {            
            for(var idx = 0; idx < 5; idx++) {
                Console.WriteLine($"Method1Sync[{idx}]");
            }
        }
        void Method2Async() {
            for(var idx = 0; idx < 5; idx++) {
                Console.WriteLine($"Method2Async[{idx}]");
            }
        }

        static void Main(string[] args) {
            var pgm = new Program();
            Task.Run(() => pgm.Method2Async());
            Task.Run(() => pgm.Method1Sync());
            Console.WriteLine("Done...");
            //Console.WriteLine(pgm.GetString("Before"));
            //Console.WriteLine(await pgm.CallBcms());
            //Console.WriteLine(pgm.GetString("after"));
        }
    }
}
