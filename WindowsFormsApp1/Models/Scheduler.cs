using System;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1.Models
{
    public static class Scheduler
    {
        private static CancellationTokenSource tokenSource;
        private static IExchangeRatesService exchangeRateService;
        private static IOfficialRatesService officialRatesService;

        public static void StartScheduling(IExchangeRatesService service, IOfficialRatesService officialService)
        {
            exchangeRateService = service;
            officialRatesService = officialService;

            // Create a cancellation token source to stop the task if needed
            tokenSource = new CancellationTokenSource();

            // Start the scheduling task
            Task.Run(ScheduleTask);
        }
        /// <summary>
        ///  
        /// </summary>
        public static void StopScheduling()
        {
            // Cancel the task and dispose the cancellation token source
            tokenSource?.Cancel();
            tokenSource?.Dispose();
        }

        private static async Task ScheduleTask()
        {
            while (!tokenSource.Token.IsCancellationRequested)
            {
                DateTime now = DateTime.Now;

                if (now.Hour == 15 && now.Minute == 00 && now.Second == 00)
                {
                    // Execute the AddNBRMDataInDataBase() method
                    exchangeRateService.AddNBRMDataInDataBase();
                    officialRatesService.AddNBRMDataInDataBase();
                }

                await Task.Delay(1000);  // Delay for 1 second
            }
        }
    }

}
