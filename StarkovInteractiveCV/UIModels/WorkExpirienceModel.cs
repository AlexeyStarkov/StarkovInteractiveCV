using System;
using System.Collections.Generic;

namespace StarkovInteractiveCV.UIModels
{
    public struct WorkExpirienceModel
    {
        public DateTime StartWorkDate { get; }
        public DateTime EndWorkDate { get; }
        public TimeSpan Duration => EndWorkDate - StartWorkDate;
        public string CompanyName { get; }
        public string PositionName { get; }
        public IEnumerable<string> Achievements { get; }
        public IEnumerable<string> Responsibilities { get; }

        public WorkExpirienceModel(DateTime startWorkDate, DateTime endWorkDate, string companyName, string positionName, IEnumerable<string> achievements, IEnumerable<string> responsibilities)
        {
            StartWorkDate = startWorkDate;
            EndWorkDate = endWorkDate;
            CompanyName = companyName;
            PositionName = positionName;
            Achievements = achievements;
            Responsibilities = responsibilities;
        }
    }
}
