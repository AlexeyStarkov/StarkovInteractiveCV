using System;
using System.Collections.Generic;
using NodaTime;
using Xamarin.Forms;

namespace StarkovInteractiveCV.Models
{
    public class WorkExpirienceModel
    {
        private readonly string _workCityName;
        private readonly string _workCountryName;

        public DateTime StartWorkDate { get; }
        public DateTime EndWorkDate { get; }
        public bool IsCurrentWork => EndWorkDate.Year == DateTime.Now.Year && EndWorkDate.Month == DateTime.Now.Month && EndWorkDate.Day == DateTime.Now.Day;
        public string CompanyName { get; }
        public string WorkPlaceName => $"{_workCityName}, {_workCountryName}";

        public IEnumerable<string> Achivements { get; }
        public IDictionary<string, IEnumerable<string>> RolesAndresponsibilities { get; }

        public FormattedString WorkPeriodString
        {
            get
            {
                var formattedString = new FormattedString();
                formattedString.Spans.Add(new Span() { Text = StartWorkDate.ToString("MMM yyyy") });
                formattedString.Spans.Add(new Span() { Text = " - " });

                if (IsCurrentWork)
                {
                    var newFont = (string)(OnPlatform<string>)App.Current.Resources["SecondaryFont"];
                    formattedString.Spans.Add(new Span() { Text = "Present", FontFamily = newFont });
                }
                else
                {
                    formattedString.Spans.Add(new Span() { Text = EndWorkDate.ToString("MMM yyyy") });
                }

                formattedString.Spans.Add(new Span() { Text = " (" });
                if (CalculateWorkPeriod.Years > 0)
                    formattedString.Spans.Add(new Span() { Text = $"{CalculateWorkPeriod.Years}yr. " });
                formattedString.Spans.Add(new Span() { Text = $"{CalculateWorkPeriod.Months}mos.)" });

                return formattedString;
            }
        }

        public WorkExpirienceModel(DateTime startWorkDate, DateTime endWorkDate, string companyName, string workCityName, string workCountryName, IEnumerable<string> achivements, IDictionary<string, IEnumerable<string>> rolesAndresponsibilities)
        {
            StartWorkDate = startWorkDate;
            EndWorkDate = endWorkDate;
            CompanyName = companyName;
            Achivements = achivements;
            RolesAndresponsibilities = rolesAndresponsibilities;
            _workCityName = workCityName;
            _workCountryName = workCountryName;
        }

        private Period CalculateWorkPeriod => Period.Between(LocalDateTime.FromDateTime(StartWorkDate), IsCurrentWork ? LocalDateTime.FromDateTime(DateTime.Now) : LocalDateTime.FromDateTime(EndWorkDate));
    }
}
