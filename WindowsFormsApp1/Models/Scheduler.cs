using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1.Models
{
    public static class Scheduler
    {
        private static CancellationTokenSource tokenSource;
        private static IExchangeRatesService exchangeRateService;

        public static void StartScheduling(IExchangeRatesService service)
        {
            exchangeRateService = service;

            // Create a cancellation token source to stop the task if needed
            tokenSource = new CancellationTokenSource();

            // Start the scheduling task
            Task.Run(ScheduleTask);
        }

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

                if (now.Hour == 10 && now.Minute == 0 && now.Second == 0)
                {
                    // Execute the AddNBRMDataInDataBase() method
                    exchangeRateService.AddNBRMDataInDataBase();
                }

                await Task.Delay(1000);  // Delay for 1 second
            }
        }

        //private static async Task ScheduleTask()
        //{
        //    DateTime now = DateTime.Now;
        //    DateTime nextRunTime = CalculateNextRunTime(now);

        //    // Calculate the initial delay until the next occurrence of 12:00:00
        //    TimeSpan initialDelay = nextRunTime - now;

        //    await Task.Delay(initialDelay);

        //    while (!tokenSource.Token.IsCancellationRequested)
        //    {
        //        // Execute the AddNBRMDataInDataBase() method
        //        exchangeRateService.AddNBRMDataInDataBase();

        //        // Calculate the next run time
        //        now = DateTime.Now;
        //        nextRunTime = CalculateNextRunTime(now);

        //        // Calculate the delay until the next occurrence of 12:00:00
        //        TimeSpan delay = nextRunTime - now;

        //        // Delay until the next occurrence of 12:00:00
        //        await Task.Delay(delay);
        //    }
        //}

        //private static DateTime CalculateNextRunTime(DateTime now)
        //{
        //    DateTime nextRunTime = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);

        //    if (nextRunTime <= now)
        //    {
        //        nextRunTime = nextRunTime.AddDays(1);
        //    }

        //    return nextRunTime;
        //}

    }

}
