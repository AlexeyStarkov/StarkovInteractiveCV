using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.MainPage
{
    public partial class MainPage : ContentPage
    {
        private const double HeaderGridMinHeight = 80;
        private const double HeaderGridHeightFactor = 0.4;

        private double _headerGridHeightDefault;

        public MainPage()
        {
            InitializeComponent();
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
