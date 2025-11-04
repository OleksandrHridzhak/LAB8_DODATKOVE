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
    public abstract class President //Базовий клас для всіх президентів
    {
      public string Name { get; set; }
      public Label HisLabel { get; set; } // Проперті для збереження посилання на відповідний Label
      public abstract void Slogan(); //Абстрактний метод для гасла президента
    }

    public interface IVticach //Інтерфейс для втікачів
    {
      string KrainaPerehovyvania { get; set; } //Проперті для країни, куди втікає президент
      void Tikaty(string VtikatyV); //Метод для втікання

    }
    public interface IRussianBusinessSeller //Інтерфейсс для продавання заводу рошен в росії
    { 
    
      void Prodavat(string shoProdavat); //Метод для продавання
    }
    public interface IVidzhumach //Інтерфейс для віджимачів бізнесів у олігархів
    {
      string BussinesDlaVidzhumania { get; set; } //Проперті для бізнесу, який віджимають
      void Vidzhymaty(string shchoVidzhymaty); //Метод для віджимання
    }
    public interface IDemocracyAtacker //Інтерфейс для атакувальників демократії
    {
      string MethodOfAttack { get; set; } //Проперті для методу атаки
      void Atakuvaty(string shchoAtakuvaty); //Метод для атаки
    }

    public class Zelensky: President, IVidzhumach, IDemocracyAtacker //Клас Зеленського, який наслідує базовий клас Президент та реалізує інтерфейси IVidzhumach та IDemocracyAtacker
    {
      public string BussinesDlaVidzhumania { get; set; } // Обовязкове проперті з інтерфейсу IVidzhumach
      public string MethodOfAttack { get; set; } // Обовязкове проперті з інтерфейсу IDemocracyAtacker
      public Zelensky(Label label) //Конструктор класу, який приймає Label для відображення інформації
      {
        Name = "Володимир Зеленський";
        HisLabel = label;
      }
      public override void Slogan() // Реалізація абстрактного методу Slogan з базового класу President
      {
        HisLabel.Text = Name + " каже: "  + "Щаc позвоню Баканову по поводу этого черта";
      }
      public void Vidzhymaty(string shchoVidzhymaty)// Реалізація методу Vidzhymaty з інтерфейсу IVidzhumach
      {
        BussinesDlaVidzhumania = shchoVidzhymaty;
        HisLabel.Text += "\n" + Name + " виджимає " + BussinesDlaVidzhumania;
      }
      public void Atakuvaty(string shchoAtakuvaty) // Реалізація методу Atakuvaty з інтерфейсу IDemocracyAtacker
      {
        MethodOfAttack = shchoAtakuvaty;
        HisLabel.Text += "\n" + Name + " атакує " + MethodOfAttack;
      }
    }
    public class Poroshenko : President, IRussianBusinessSeller //Клас Порошенка, який наслідує базовий клас Президент та реалізує інтерфейс IRussianBusinessSeller
    {
      public Poroshenko(Label label) //Конструктор класу, який приймає Label для відображення інформації
      {
        Name = "Петро Порошенко";
        HisLabel = label;
      }
      public void Prodavat(string shoProdavat) // Реалізація методу Prodavat з інтерфейсу IRussianBusinessSeller
      {
        HisLabel.Text += "\n" + Name + " продає " + shoProdavat;
      }

      public override void Slogan() // Реалізація абстрактного методу Slogan з базового класу President
      {
        HisLabel.Text = Name + " каже: " + "Прощай, немытая Россия";
      }
    }

    public class Yanukovych : President, IVticach, IDemocracyAtacker //Клас Януковича, який наслідує базовий клас Президент та реалізує інтерфейси IVticach та IDemocracyAtacker
    {
      public string KrainaPerehovyvania { get; set; } // Обовязкове проперті з інтерфейсу IVticach
      public string MethodOfAttack { get; set; } // Обовязкове проперті з інтерфейсу IDemocracyAtacker
      public void Tikaty(string VtikatyV) // Реалізація методу Tikaty з інтерфейсу IVticach
      {
        KrainaPerehovyvania = VtikatyV;
        HisLabel.Text += "\n" + Name + " втікає в " + KrainaPerehovyvania;
      }
      public void Atakuvaty(string shchoAtakuvaty) // Реалізація методу Atakuvaty з інтерфейсу IDemocracyAtacker
      {
        MethodOfAttack = shchoAtakuvaty;
        HisLabel.Text += "\n" + Name + " атакує " + MethodOfAttack;
      }
      public Yanukovych(Label label) //Конструктор класу, який приймає Label для відображення інформації
      {
        Name = "Віктор Янукович";
        HisLabel = label;
      }

      public override void Slogan() // Реалізація абстрактного методу Slogan з базового класу President
      {
        HisLabel.Text = Name + " каже: " + "ви забили? забули про це? я вам трошки напам'ятаю";
      }
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }



    private void button1_Click(object sender, EventArgs e)
    {
      //Створення об'єкта класу Зеленський та виклик його методів
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
      //Створення об'єкта класу Порошенко та виклик його методів
      Poroshenko poroshenko = new Poroshenko(label2);
      poroshenko.Slogan();
      poroshenko.Prodavat("Roshen");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      //Створення об'єкта класу Янукович та виклик його методів
      Yanukovych yanukovych = new Yanukovych(label3);
      yanukovych.Slogan();
      yanukovych.Tikaty("Росію");
      yanukovych.Atakuvaty("Євромайдан");

    }
  }
}
