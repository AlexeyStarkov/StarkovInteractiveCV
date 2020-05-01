using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StarkovInteractiveCV.Controls
{
    public class ContentButton : Frame
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(BorderColor), typeof(ICommand), typeof(ContentButton), default, propertyChanged: OnCommandChanged);

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        protected override void OnParentSet()
        {
            Content.InputTransparent = true;
            Padding = 0;
            base.OnParentSet();
        }

        private async Task AnimateClickAsync()
        {
            await this.ScaleTo(0.85, 35);
            await this.ScaleTo(1, 35);
        }

        private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue is ICommand newCommand)
            {
                var button = (ContentButton)bindable;
                button.GestureRecognizers.Clear();
                button.GestureRecognizers.Add(new TapGestureRecognizer()
                {
                    Command = new Command(async () =>
                    {
                        await button.AnimateClickAsync();
                        newCommand.Execute(null);
                    })
                });
            }
        }
    }
}
