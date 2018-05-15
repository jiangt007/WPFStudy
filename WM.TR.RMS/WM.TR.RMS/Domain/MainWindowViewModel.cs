using System.Configuration;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using System.Windows.Controls;
using System;

namespace WM.TR.RMS.Domain
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel(ISnackbarMessageQueue snackbarMessageQueue)
        {
            if (snackbarMessageQueue == null) throw new ArgumentNullException(nameof(snackbarMessageQueue));

            DemoItems = new[]
            {
                new DemoItem("Cards", new Cards(), new []
                    {
                        DocumentationLink.DemoPageLink<Cards>(),
                        DocumentationLink.StyleLink("Card"),
                        DocumentationLink.ApiLink<Card>()
                    })
                {
                    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                },
            };
        }

        public DemoItem[] DemoItems { get; }
    }
}