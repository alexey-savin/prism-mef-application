using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace Prism.MefApplication.Modules.SimpleTextBlockModule.Views
{
    /// <summary>
    /// Логика взаимодействия для HelloPrismView.xaml
    /// </summary>
    [Export(typeof(HelloPrismView))]
    public partial class HelloPrismView : UserControl
    {
        public HelloPrismView()
        {
            InitializeComponent();
        }
    }
}
