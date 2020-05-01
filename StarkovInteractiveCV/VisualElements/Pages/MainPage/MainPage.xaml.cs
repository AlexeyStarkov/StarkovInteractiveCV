using System;
using StarkovInteractiveCV.Helpers;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.MainPage
{
    public partial class MainPage : ContentPage
    {
        private const double HeaderGridMinHeight = 50;
        private const double HeaderGridHeightFactor = 0.65;
        private const double PhotoMaxSize = 200;
        private const double MiniPhotoTranslationX = 10;

        private readonly Point[] _satellitesTranslations;

        private double _headerGridHeightDefault;

        public MainPage()
        {
            InitializeComponent();

            Photo.WidthRequest = PhotoMaxSize;
            Photo.HeightRequest = PhotoMaxSize;
            NameGrid.HeightRequest = HeaderGridMinHeight;

            _satellitesTranslations = Tools.GetStarTopsCoordinates(9, new Point(0, 0), 140, 2);

            HobbiesButton.TranslationX = _satellitesTranslations[0].X;
            HobbiesButton.TranslationY = _satellitesTranslations[0].Y;

            WorkflowButton.TranslationX = _satellitesTranslations[1].X;
            WorkflowButton.TranslationY = _satellitesTranslations[1].Y;

            DevSkilsButton.TranslationX = _satellitesTranslations[2].X;
            DevSkilsButton.TranslationY = _satellitesTranslations[2].Y;

            ToolsButton.TranslationX = _satellitesTranslations[3].X;
            ToolsButton.TranslationY = _satellitesTranslations[3].Y;

            ProfileButton.TranslationX = _satellitesTranslations[4].X;
            ProfileButton.TranslationY = _satellitesTranslations[4].Y;

            ContactButton.TranslationX = _satellitesTranslations[5].X;
            ContactButton.TranslationY = _satellitesTranslations[5].Y;

            SocialButton.TranslationX = _satellitesTranslations[6].X;
            SocialButton.TranslationY = _satellitesTranslations[6].Y;

            LanguagesButton.TranslationX = _satellitesTranslations[7].X;
            LanguagesButton.TranslationY = _satellitesTranslations[7].Y;

            PersonalityButton.TranslationX = _satellitesTranslations[8].X;
            PersonalityButton.TranslationY = _satellitesTranslations[8].Y;
        }

        protected override void OnParentSet()
        {
            SizeChanged += (s, e) =>
            {
                if (Height > 0 && Width > 0)
                {
                    HeaderFrame.HeightRequest = _headerGridHeightDefault = this.Height * HeaderGridHeightFactor;
                    ScrollableStack.Padding = new Thickness(0, _headerGridHeightDefault, 0, 150);
                }
            };

            Scroll.Scrolled += OnScrollScrolled;

            base.OnParentSet();
        }

        private void OnScrollScrolled(object sender, ScrolledEventArgs e)
        {
            if (_headerGridHeightDefault - e.ScrollY < HeaderGridMinHeight)
                HeaderFrame.HeightRequest = HeaderGridMinHeight;
            else if(_headerGridHeightDefault - e.ScrollY >= _headerGridHeightDefault)
                HeaderFrame.HeightRequest = _headerGridHeightDefault;
            else
                HeaderFrame.HeightRequest = _headerGridHeightDefault - e.ScrollY;

            var headerMovementProgressFactor = Math.Pow((HeaderFrame.HeightRequest - HeaderGridMinHeight) / (_headerGridHeightDefault - HeaderGridMinHeight), 4);

            HobbiesButton.TranslationX = _satellitesTranslations[0].X * headerMovementProgressFactor;
            HobbiesButton.TranslationY = _satellitesTranslations[0].Y * headerMovementProgressFactor;
            WorkflowButton.TranslationX = _satellitesTranslations[1].X * headerMovementProgressFactor;
            WorkflowButton.TranslationY = _satellitesTranslations[1].Y * headerMovementProgressFactor;
            DevSkilsButton.TranslationX = _satellitesTranslations[2].X * headerMovementProgressFactor;
            DevSkilsButton.TranslationY = _satellitesTranslations[2].Y * headerMovementProgressFactor;
            ToolsButton.TranslationX = _satellitesTranslations[3].X * headerMovementProgressFactor;
            ToolsButton.TranslationY = _satellitesTranslations[3].Y * headerMovementProgressFactor;
            ProfileButton.TranslationX = _satellitesTranslations[4].X * headerMovementProgressFactor;
            ProfileButton.TranslationY = _satellitesTranslations[4].Y * headerMovementProgressFactor;
            ContactButton.TranslationX = _satellitesTranslations[5].X * headerMovementProgressFactor;
            ContactButton.TranslationY = _satellitesTranslations[5].Y * headerMovementProgressFactor;
            SocialButton.TranslationX = _satellitesTranslations[6].X * headerMovementProgressFactor;
            SocialButton.TranslationY = _satellitesTranslations[6].Y * headerMovementProgressFactor;
            LanguagesButton.TranslationX = _satellitesTranslations[7].X * headerMovementProgressFactor;
            LanguagesButton.TranslationY = _satellitesTranslations[7].Y * headerMovementProgressFactor;
            PersonalityButton.TranslationX = _satellitesTranslations[8].X * headerMovementProgressFactor;
            PersonalityButton.TranslationY = _satellitesTranslations[8].Y * headerMovementProgressFactor;

            var satellitesOpacity = Math.Pow((HeaderFrame.HeightRequest - HeaderGridMinHeight) / (_headerGridHeightDefault - HeaderGridMinHeight), 7) * 1.2;

            HobbiesButton.Opacity = satellitesOpacity;
            WorkflowButton.Opacity = satellitesOpacity;
            DevSkilsButton.Opacity = satellitesOpacity;
            ToolsButton.Opacity = satellitesOpacity;
            ProfileButton.Opacity = satellitesOpacity;
            ContactButton.Opacity = satellitesOpacity;
            SocialButton.Opacity = satellitesOpacity;
            LanguagesButton.Opacity = satellitesOpacity;
            PersonalityButton.Opacity = satellitesOpacity;

            var photoMovementScaleFactor = Math.Pow((HeaderFrame.HeightRequest - HeaderGridMinHeight) / (_headerGridHeightDefault - HeaderGridMinHeight), 1.5) * 1.4 + 0.2;

            var photoNewSize = PhotoMaxSize * photoMovementScaleFactor;
            if (photoNewSize > PhotoMaxSize)
                photoNewSize = PhotoMaxSize;

            Photo.HeightRequest = photoNewSize;
            Photo.WidthRequest = photoNewSize;

            var photoMovementFactor = 1 - (HeaderFrame.HeightRequest - HeaderGridMinHeight) / (_headerGridHeightDefault - HeaderGridMinHeight) * 1.4;
            if (photoMovementFactor < 0)
                photoMovementFactor = 0;

            var _miniPhotoTranslationX = -(Width / 2 - photoNewSize / 2) + MiniPhotoTranslationX;
            Photo.TranslationX = _miniPhotoTranslationX * photoMovementFactor;

            var nameGridOpacityFactor = 1 - Math.Pow((HeaderFrame.HeightRequest - HeaderGridMinHeight) / (_headerGridHeightDefault - HeaderGridMinHeight), 2) * 1.5;
            NameLabel.Opacity = nameGridOpacityFactor;
        }
    }
}
