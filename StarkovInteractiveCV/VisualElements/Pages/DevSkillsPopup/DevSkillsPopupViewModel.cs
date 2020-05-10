using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using StarkovInteractiveCV.VisualElements.Pages.DevSkillsPopup.Enums;
using StarkovInteractiveCV.VisualElements.Pages.DevSkillsPopup.UIModels;

namespace StarkovInteractiveCV.VisualElements.Pages.DevSkillsPopup
{
    public class DevSkillsPopupViewModel : ViewModelBase
    {
        private IEnumerable<SkillUIModel> _skills;
        public IEnumerable<SkillUIModel> Skills
        {
            get => _skills;
            set => SetProperty(ref _skills, value);
        }

        private IEnumerable<SkillUIModel> _tools;
        public IEnumerable<SkillUIModel> Tools
        {
            get => _tools;
            set => SetProperty(ref _tools, value);
        }

        private IEnumerable<SkillUIModel> _idustries;
        public IEnumerable<SkillUIModel> Industries
        {
            get => _idustries;
            set => SetProperty(ref _idustries, value);
        }

        public DevSkillsPopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Industries = new List<SkillUIModel>()
            {
                new SkillUIModel(KnowledgeType.Industry, "Industrial automation"),
                new SkillUIModel(KnowledgeType.Industry, "Car washing"),
                new SkillUIModel(KnowledgeType.Industry, "Restaurant")
            };

            Skills = new List<SkillUIModel>()
            {
                new SkillUIModel(KnowledgeType.ProgrammingLanguage, "C#"),
                new SkillUIModel(KnowledgeType.ProgrammingLanguage, "VB.NET"),
                new SkillUIModel(KnowledgeType.Technology, "Xamarin"),
                new SkillUIModel(KnowledgeType.Technology, "WPF"),
                new SkillUIModel(KnowledgeType.Technology, "Silverlight"),
                new SkillUIModel(KnowledgeType.Technology, "ASP.NET MVC Web API (+ Core)"),
                new SkillUIModel(KnowledgeType.Technology, "Entity Framework"),
                new SkillUIModel(KnowledgeType.Technology, ".NET Framework"),
                new SkillUIModel(KnowledgeType.Technology, "MVVM"),
                new SkillUIModel(KnowledgeType.Technology, "MVC"),
                new SkillUIModel(KnowledgeType.Database, "LiteDB"),
                new SkillUIModel(KnowledgeType.Database, "SQLIte"),
                new SkillUIModel(KnowledgeType.Database, "MS SQL"),
                new SkillUIModel(KnowledgeType.Database, "MySQL"),
                new SkillUIModel(KnowledgeType.Database, "Code First"),
                new SkillUIModel(KnowledgeType.Database, "DB First"),
                new SkillUIModel(KnowledgeType.Other, "XAML"),
                new SkillUIModel(KnowledgeType.Other, "JSON"),
                new SkillUIModel(KnowledgeType.Other, "SCADA"),
                new SkillUIModel(KnowledgeType.Other, "Serial interfaces"),
                new SkillUIModel(KnowledgeType.Other, "Binary protocols"),
                new SkillUIModel(KnowledgeType.Other, "Payment providers")
            };
            Skills = Skills.OrderBy(x => x.SkillType).ThenBy(x => x.Name.Length);

            Tools = new List<SkillUIModel>()
            {
                new SkillUIModel(KnowledgeType.Tool, "Visual Studio"),
                new SkillUIModel(KnowledgeType.Tool, "Visual Studio Mac"),
                new SkillUIModel(KnowledgeType.Tool, "Azure DevOps"),
                new SkillUIModel(KnowledgeType.Tool, "Azure"),
                new SkillUIModel(KnowledgeType.Tool, "GIT"),
                new SkillUIModel(KnowledgeType.Tool, "TFS"),
                new SkillUIModel(KnowledgeType.Tool, "SQL Management Studio"),
                new SkillUIModel(KnowledgeType.Tool, "Azure Data Studio"),
                new SkillUIModel(KnowledgeType.Tool, "Adobe XD"),
                new SkillUIModel(KnowledgeType.Tool, "Adobe Photoshop"),
                new SkillUIModel(KnowledgeType.Tool, "Principle"),
                new SkillUIModel(KnowledgeType.Tool, "Jira"),
                new SkillUIModel(KnowledgeType.Tool, "Teamweek"),
                new SkillUIModel(KnowledgeType.Tool, "Wireshark"),
            };

            base.OnNavigatedTo(parameters);
        }
    }
}
