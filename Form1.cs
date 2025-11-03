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
    public interface IRussianBusinessSeller 
    { 
    
      void Prodavat(string shoProdavat);
    }
    public interface IVidzhumach
    {
      string BussinesDlaVidzhumania { get; set; }
      void Vidzhymaty(string shchoVidzhymaty);
    }
    public interface IDemocracyAtacker
    {
      string MethodOfAttack { get; set; }
      void Atakuvaty(string shchoAtakuvaty);
    }

    public class Zelensky: President, IVidzhumach, IDemocracyAtacker
    {
      public string BussinesDlaVidzhumania { get; set; }
      public string MethodOfAttack { get; set; }
      public Zelensky(Label label)
      {
        Name = "Володимир Зеленський";
        HisLabel = label;
      }
      public override void Slogan()
      {
        HisLabel.Text = Name + " каже: "  + "Щаc позвоню Баканову по поводу этого черта";
      }
      public void Vidzhymaty(string shchoVidzhymaty)
      {
        BussinesDlaVidzhumania = shchoVidzhymaty;
        HisLabel.Text += "\n" + Name + " виджимає " + BussinesDlaVidzhumania;
      }
      public void Atakuvaty(string shchoAtakuvaty)
      {
        MethodOfAttack = shchoAtakuvaty;
        HisLabel.Text += "\n" + Name + " атакує " + MethodOfAttack;
      }
    }
    public class Poroshenko : President, IRussianBusinessSeller
    {
      public Poroshenko(Label label)
      {
        Name = "Петро Порошенко";
        HisLabel = label;
      }
      public void Prodavat(string shoProdavat)
      {
        HisLabel.Text += "\n" + Name + " продає " + shoProdavat;
      }

      public override void Slogan()
      {
        HisLabel.Text = Name + " каже: " + "Прощай, немытая Россия";
      }
    }

    public class Yanukovych : President, IVticach, IDemocracyAtacker
    {
      public string KrainaPerehovyvania { get; set; }
      public string MethodOfAttack { get; set; }
      public void Tikaty(string VtikatyV)
      {
        KrainaPerehovyvania = VtikatyV;
        HisLabel.Text += "\n" + Name + " втікає в " + KrainaPerehovyvania;
      }
      public void Atakuvaty(string shchoAtakuvaty)
      {
        MethodOfAttack = shchoAtakuvaty;
        HisLabel.Text += "\n" + Name + " атакує " + MethodOfAttack;
      }
      public Yanukovych(Label label)
      {
        Name = "Віктор Янукович";
        HisLabel = label;
      }

      public override void Slogan()
      {
        HisLabel.Text = Name + " каже: " + "ви забили? забули про це? я вам трошки напам'ятаю";
      }
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }



    private void button1_Click(object sender, EventArgs e)
    {
      Zelensky zelensky = new Zelensky(label1);
      zelensky.Slogan();
      zelensky.Vidzhymaty("PrivatBank");
      zelensky.Atakuvaty("НАБУ");

    }

    private void label1_Click(object sender, EventArgs e)
    {
      
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Poroshenko poroshenko = new Poroshenko(label2);
      poroshenko.Slogan();
      poroshenko.Prodavat("Roshen");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Yanukovych yanukovych = new Yanukovych(label3);
      yanukovych.Slogan();
      yanukovych.Tikaty("Росію");
      yanukovych.Atakuvaty("Євромайдан");

    }
  }
}
