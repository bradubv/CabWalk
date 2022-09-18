using Cnt.CompositeUI.SmartParts;

namespace MyModule
{
    [SmartPart]
    public partial class MyView : UserControl, IMyView
    {
        public MyView()
        {
            InitializeComponent();
        }

        #region IMyView Members

        public string Message
        {
            get
            {
                return this.label1.Text;
            }
            set 
            {
                this.label1.Text = value;
            }
        }

        #endregion
    }
}
