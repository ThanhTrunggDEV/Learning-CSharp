using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Learning_CSharp.Learning_At_School
{
    
    public class PhanSo
    {
        private int tuSo;
        private int mauSo;
        public int TuSo { get { return tuSo; } set { tuSo = value; } }
        public int MauSo { get { return mauSo; } set { mauSo = value; } }
        private int Cal_UCLN()
        {
            for (int i = TuSo; i >= 1; i--)
            {
                if(TuSo % i == 0 && MauSo % i == 0)
                    return i;
            }
            return 1;
        }
        public void RutGon()
        {
            int UCLN = Cal_UCLN();
            TuSo /= UCLN;
            MauSo /= UCLN;
        }
        public void Display()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

    }
    public class HinhChuNhat
    {
        private float chieuDai;
        private float chieuRong;

        public float ChieuDai { get { return chieuDai; } set { chieuDai = value; } }
        public float ChieuRong { get { return chieuRong; } set { chieuRong = value; } }
        public void Cal_Perimeter()
        {
            Console.WriteLine($"Perimeter: {(ChieuDai + ChieuRong) * 2}");
        }

        public void Cal_Area()
        {
            Console.WriteLine($"Area: {ChieuDai * ChieuRong}");
        }
    }
    public class Student
    {
        private string fullName, homeTown;
        private int age;
        private float mathScore, itScore, englishScore,uuTienScore;
        public string FullName {  get { return fullName; } set { fullName = value; } }
        public string HomeTown { get { return homeTown; } set { homeTown = value; } }
        public int Age { get { return age; } set { age = value; } }
        public float MathScore { get { return mathScore; } set { mathScore = value; } }
        public float ITScore {  get { return itScore; } set { itScore = value; } }
        public float EnglishScore { get {return englishScore; } set { englishScore = value; } }

        public void Cal_AverageScore()
        {
            if (HomeTown == "Bac Giang" || HomeTown == "Lang Son")
                uuTienScore = 0.5f;
            float averageScore = 0;
            averageScore = (MathScore + ITScore + EnglishScore + uuTienScore) / 3;
            Console.WriteLine($"Average Score Is {averageScore}");
        }
        public void DisplayInfor()
        {
            Console.WriteLine($"Full Name: {FullName}\n" +
                              $"Hometown: {HomeTown}\n" +
                              $"Age: {Age}\n" +
                              $"Math Score: {MathScore}\n" +
                              $"IT Score: {ITScore}\n" +
                              $"English Score: {EnglishScore}");
        }
    }
}
