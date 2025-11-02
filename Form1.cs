using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8_DODATKOVE
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    public abstract class President
    {
      public string Name { get; set; }
      public Label HisLabel { get; set; }
      public abstract void Slogan();
    }

    public interface IVticach
    {
      string KrainaPerehovyvania { get; set; }
      void Tikaty(string VtikatyV);

    }

    public class Zelensky: President
    {
      public Zelensky(Label label)
      {
        Name = "Володимир Зеленський";
        HisLabel = label;
      }
      public override void Slogan()
      {
        HisLabel.Text = "Ща позвоню Баканову по поводу этого черта";
      }
    }
    public class Poroshenko : President
    {
      public Poroshenko(Label label)
      {
        Name = "Петро Порошенко";
        HisLabel = label;
      }

      public override void Slogan()
      {
        HisLabel.Text = "Прощай, немытая Россия";
      }
    }

    public class Yanukovych : President
    {
      public Yanukovych(Label label)
      {
        Name = "Віктор Янукович";
        HisLabel = label;
      }

      public override void Slogan()
      {
        HisLabel.Text = "ви забили? забули про це? я вам трошки напам'ятаю";
      }
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }



    private void button1_Click(object sender, EventArgs e)
    {
      
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {

    }
  }
}
