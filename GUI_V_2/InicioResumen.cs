using System;
using System.Windows.Forms;

namespace GUI_V_2
{
  public partial class InicioResumen : Form
  {
    public InicioResumen()
    {
      InitializeComponent();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      LabelHour.Text = DateTime.Now.ToString("hh:mm:ss ");
      LabelDate.Text = DateTime.Now.ToLongDateString();
    }
  }
}
