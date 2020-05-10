using System.Collections.Generic;
using System.Linq;
using StarkovInteractiveCV.Models;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.MainPage.UIModels
{
    public class WorkExpirienceUIModel
    {
        private const double TileRoleLineHeight = 22;

        private readonly WorkExpirienceModel _workExpirience;

        public double TileHeaderHeight => 40;
        public double TileBasementHeight => 40;
        public double TileHeight => TileHeaderHeight + TileBasementHeight + (Roles != null ? Roles.Count() * TileRoleLineHeight : 0) + 20;

        public string CompanyName => _workExpirience.CompanyName;
        public FormattedString WorkPeriod => _workExpirience.WorkPeriodString;
        public IEnumerable<string> Roles => _workExpirience.RolesAndresponsibilities?.Keys;
        public string WorkPlaceName => _workExpirience.WorkPlaceName;

        public WorkExpirienceUIModel(WorkExpirienceModel workExpirienceModel)
        {
            _workExpirience = workExpirienceModel;
        }

        public WorkExpirienceModel GetOriginalModel() => _workExpirience;
    }
}
