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

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void labelEmployeesBottom_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void label9_Click(object sender, EventArgs e)
    {

    }

    private void label16_Click(object sender, EventArgs e)
    {

    }
  }
}
