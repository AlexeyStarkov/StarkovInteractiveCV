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

            HobbiesButtonFrame.TranslationX = _satellitesTranslations[0].X;
            HobbiesButtonFrame.TranslationY = _satellitesTranslations[0].Y;

            WorkflowButtonFrame.TranslationX = _satellitesTranslations[1].X;
            WorkflowButtonFrame.TranslationY = _satellitesTranslations[1].Y;

            DevSkilsButtonFrame.TranslationX = _satellitesTranslations[2].X;
            DevSkilsButtonFrame.TranslationY = _satellitesTranslations[2].Y;

            ToolsButtonFrame.TranslationX = _satellitesTranslations[3].X;
            ToolsButtonFrame.TranslationY = _satellitesTranslations[3].Y;

            ProfileButtonFrame.TranslationX = _satellitesTranslations[4].X;
            ProfileButtonFrame.TranslationY = _satellitesTranslations[4].Y;

            ContactButtonFrame.TranslationX = _satellitesTranslations[5].X;
            ContactButtonFrame.TranslationY = _satellitesTranslations[5].Y;

            SocialButtonFrame.TranslationX = _satellitesTranslations[6].X;
            SocialButtonFrame.TranslationY = _satellitesTranslations[6].Y;

            LanguagesButtonFrame.TranslationX = _satellitesTranslations[7].X;
            LanguagesButtonFrame.TranslationY = _satellitesTranslations[7].Y;

            PersonalityButtonFrame.TranslationX = _satellitesTranslations[8].X;
            PersonalityButtonFrame.TranslationY = _satellitesTranslations[8].Y;
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

            HobbiesButtonFrame.TranslationX = _satellitesTranslations[0].X * headerMovementProgressFactor;
            HobbiesButtonFrame.TranslationY = _satellitesTranslations[0].Y * headerMovementProgressFactor;
            WorkflowButtonFrame.TranslationX = _satellitesTranslations[1].X * headerMovementProgressFactor;
            WorkflowButtonFrame.TranslationY = _satellitesTranslations[1].Y * headerMovementProgressFactor;
            DevSkilsButtonFrame.TranslationX = _satellitesTranslations[2].X * headerMovementProgressFactor;
            DevSkilsButtonFrame.TranslationY = _satellitesTranslations[2].Y * headerMovementProgressFactor;
            ToolsButtonFrame.TranslationX = _satellitesTranslations[3].X * headerMovementProgressFactor;
            ToolsButtonFrame.TranslationY = _satellitesTranslations[3].Y * headerMovementProgressFactor;
            ProfileButtonFrame.TranslationX = _satellitesTranslations[4].X * headerMovementProgressFactor;
            ProfileButtonFrame.TranslationY = _satellitesTranslations[4].Y * headerMovementProgressFactor;
            ContactButtonFrame.TranslationX = _satellitesTranslations[5].X * headerMovementProgressFactor;
            ContactButtonFrame.TranslationY = _satellitesTranslations[5].Y * headerMovementProgressFactor;
            SocialButtonFrame.TranslationX = _satellitesTranslations[6].X * headerMovementProgressFactor;
            SocialButtonFrame.TranslationY = _satellitesTranslations[6].Y * headerMovementProgressFactor;
            LanguagesButtonFrame.TranslationX = _satellitesTranslations[7].X * headerMovementProgressFactor;
            LanguagesButtonFrame.TranslationY = _satellitesTranslations[7].Y * headerMovementProgressFactor;
            PersonalityButtonFrame.TranslationX = _satellitesTranslations[8].X * headerMovementProgressFactor;
            PersonalityButtonFrame.TranslationY = _satellitesTranslations[8].Y * headerMovementProgressFactor;

            var satellitesOpacity = Math.Pow((HeaderFrame.HeightRequest - HeaderGridMinHeight) / (_headerGridHeightDefault - HeaderGridMinHeight), 7) * 1.2;

            HobbiesButtonFrame.Opacity = satellitesOpacity;
            WorkflowButtonFrame.Opacity = satellitesOpacity;
            DevSkilsButtonFrame.Opacity = satellitesOpacity;
            ToolsButtonFrame.Opacity = satellitesOpacity;
            ProfileButtonFrame.Opacity = satellitesOpacity;
            ContactButtonFrame.Opacity = satellitesOpacity;
            SocialButtonFrame.Opacity = satellitesOpacity;
            LanguagesButtonFrame.Opacity = satellitesOpacity;
            PersonalityButtonFrame.Opacity = satellitesOpacity;

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
