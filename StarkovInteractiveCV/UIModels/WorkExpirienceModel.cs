using System;
using NodaTime;
using Xamarin.Forms;

namespace StarkovInteractiveCV.UIModels
{
    public class WorkExpirienceModel
    {
        public DateTime StartWorkDate { get; }
        public DateTime EndWorkDate { get; }
        public Period WorkPeriod => Period.Between(LocalDateTime.FromDateTime(StartWorkDate), IsCurrentWork ? LocalDateTime.FromDateTime(DateTime.Now) : LocalDateTime.FromDateTime(EndWorkDate));
        public bool IsCurrentWork => EndWorkDate.Ticks == 0;
        public string CompanyName { get; }
        public string PositionName { get; }
        public string WorkPlaceName { get; }

        public FormattedString WorkPeriodString
        {
            get
            {
                var formattedString = new FormattedString();
                formattedString.Spans.Add(new Span() { Text = StartWorkDate.ToString("MMM yyyy") });
                formattedString.Spans.Add(new Span() { Text = " - " });

                if (IsCurrentWork)
                {
                    formattedString.Spans.Add(new Span() { Text = EndWorkDate.ToString("MMM yyyy") });
                }
                else
                {
                    var vvv = App.Current.Resources["SecondaryFont"];
                    var newFont = (string)App.Current.Resources["SecondaryFont"];
                    formattedString.Spans.Add(new Span() { Text = "Present", FontFamily = newFont });
                }

                formattedString.Spans.Add(new Span() { Text = " (" });
                if (WorkPeriod.Years > 0)
                    formattedString.Spans.Add(new Span() { Text = $"{WorkPeriod.Years}yr. " });
                formattedString.Spans.Add(new Span() { Text = $"{WorkPeriod.Months}mos.)" });

                return formattedString;
            }
        }

        public WorkExpirienceModel(DateTime startWorkDate, DateTime endWorkDate, string companyName, string positionName, string workCityName, string workCountryName)
        {
            StartWorkDate = startWorkDate;
            EndWorkDate = endWorkDate;
            CompanyName = companyName;
            PositionName = positionName;
            WorkPlaceName = $"{workCityName}, {workCountryName}";
        }
    }
}
