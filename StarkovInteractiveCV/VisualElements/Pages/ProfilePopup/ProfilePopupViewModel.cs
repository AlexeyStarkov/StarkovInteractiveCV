using System;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.VisualElements.BaseObjects;

namespace StarkovInteractiveCV.VisualElements.Pages.ProfilePopup
{
    public class ProfilePopupViewModel : ViewModelBase
    {
        public string Text { get; set; }

        public ProfilePopupViewModel(IExtendedNavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
            Text = CreateProfileText();
        }

        private string CreateProfileText()
        {
            return $"\tI have been developing software since 2011. During my career as a developer, I did different things successfully:{Environment.NewLine} - Payment systems integration;{Environment.NewLine} - Creating advanced software for self-service carwashes from software for technological equipment to a cloud platform and mobile app;{Environment.NewLine} - Industrial automation PLC and SCADA software;{Environment.NewLine} - Creating industrial automation software without test environment;{Environment.NewLine} - Implementation of binary protocols without documentation, etc. {Environment.NewLine}{Environment.NewLine}" +
                $"\tMoreover, I have a successful experience in different parts of the project: collecting requirements, user story design, mobile app UI/ UX design, functional specification writing, creating complete technical solutions, integration with third-party software, and managing other developers.{Environment.NewLine}{Environment.NewLine}" +
                $"\tI earned a lot of money for my customers(employers) by completing projects in accordance with the deadline.To summarize, I glad to say that my story is a story about challenges, hardworking, and passion for my business.{Environment.NewLine}{Environment.NewLine}" +
                $"\tI am a results-oriented, self-motivated, open-minded, responsible, detail-oriented, decisive person who likes to make a difference.";
        }
    }
}
