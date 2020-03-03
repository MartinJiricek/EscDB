namespace EscapeDB
{
    public partial class LoginControl : UIControlBase
    {

        public string PWD { get; private set; }

        public LoginControl()
        {
            InitializeComponent();
        }

        public void LoadConfiguration()
        {
            Configuration cfg = new Configuration();


        }
    }
}