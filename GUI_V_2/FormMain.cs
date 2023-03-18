using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI_V_2
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void BtnMenu_Click(object sender, EventArgs e)
    {
      if (MenuVertical.Width == 250)
      {
        MenuVertical.Width = 70;
      }
      else
      {
        MenuVertical.Width = 250;
      }
    }

    private void Iconcerrar_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Iconmaximizar_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Maximized;
      iconrestaurar.Visible = true;
      iconmaximizar.Visible = false;
    }

    private void Iconrestaurar_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Normal;
      iconrestaurar.Visible = false;
      iconmaximizar.Visible = true;
    }

    private void Iconminimizar_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void AbrirFormEnPanel(object Formhijo)
    {
      if (panelContenedor.Controls.Count > 0)
      {
        panelContenedor.Controls.RemoveAt(0);
      }

      Form fh = Formhijo as Form;
      fh.TopLevel = false;
      fh.Dock = DockStyle.Fill;
      panelContenedor.Controls.Add(fh);
      panelContenedor.Tag = fh;
      fh.Show();
    }

    private void Btnprod_Click(object sender, EventArgs e)
    {
      AbrirFormEnPanel(new Products());
    }

    private void BtnlogoInicio_Click(object sender, EventArgs e)
    {
      AbrirFormEnPanel(new InicioResumen());
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      BtnlogoInicio_Click(null, e);
    }
  }
}