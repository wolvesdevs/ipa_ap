using AP.Domain.Algorithms;

namespace AP.UI;

public partial class MainView : Form
{
    public MainView()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void H30SpringButton_Click(object sender, EventArgs e)
    {
        H30Spring h30Spring = new();
        h30Spring.main();
    }
}
