using StarkovInteractiveCV.Helpers;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.MainPage
{
    public partial class MainPage : ContentPage
    {
        private const double HeaderGridMinHeight = 80;
        private const double HeaderGridHeightFactor = 0.6;

        private double _headerGridHeightDefault;

        public MainPage()
        {
            InitializeComponent();

            var satellitesTranslations = Tools.GetStarTopsCoordinates(9, new Point(0, 0), 150);

            HobbiesButtonFrame.TranslationX = satellitesTranslations[0].X;
            HobbiesButtonFrame.TranslationY = satellitesTranslations[0].Y;

            WorkflowButtonFrame.TranslationX = satellitesTranslations[1].X;
            WorkflowButtonFrame.TranslationY = satellitesTranslations[1].Y;

            DevSkilsButtonFrame.TranslationX = satellitesTranslations[2].X;
            DevSkilsButtonFrame.TranslationY = satellitesTranslations[2].Y;

            ToolsButtonFrame.TranslationX = satellitesTranslations[3].X;
            ToolsButtonFrame.TranslationY = satellitesTranslations[3].Y;

            ProfileButtonFrame.TranslationX = satellitesTranslations[4].X;
            ProfileButtonFrame.TranslationY = satellitesTranslations[4].Y;

            ContactButtonFrame.TranslationX = satellitesTranslations[5].X;
            ContactButtonFrame.TranslationY = satellitesTranslations[5].Y;

            SocialButtonFrame.TranslationX = satellitesTranslations[6].X;
            SocialButtonFrame.TranslationY = satellitesTranslations[6].Y;

            LanguagesButtonFrame.TranslationX = satellitesTranslations[7].X;
            LanguagesButtonFrame.TranslationY = satellitesTranslations[7].Y;

            PersonalityButtonFrame.TranslationX = satellitesTranslations[8].X;
            PersonalityButtonFrame.TranslationY = satellitesTranslations[8].Y;
        }

        protected override void OnParentSet()
        {
            SizeChanged += (s, e) =>
            {
                if (Height > 0)
                {
                    HeaderGrid.HeightRequest = _headerGridHeightDefault = this.Height * HeaderGridHeightFactor;
                    ScrollableStack.Padding = new Thickness(0, _headerGridHeightDefault, 0, 0);
                }
            };

            Scroll.Scrolled += OnScrollScrolled;

            base.OnParentSet();
        }

        private void OnScrollScrolled(object sender, ScrolledEventArgs e)
        {
            if (_headerGridHeightDefault - e.ScrollY < HeaderGridMinHeight)
                HeaderGrid.HeightRequest = HeaderGridMinHeight;
            else if(_headerGridHeightDefault - e.ScrollY >= _headerGridHeightDefault)
                HeaderGrid.HeightRequest = _headerGridHeightDefault;
            else
                HeaderGrid.HeightRequest = _headerGridHeightDefault - e.ScrollY;
        }
    }
}
