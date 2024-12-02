using System;

namespace LabWork
{

    // Клас для опису прямої у двовимірному просторі.

    class Line
    {
        private double a1;
        private double a2;
        private double a0;

        public double A1
        {
            get { return a1; }
            set { a1 = value; }
        }

        public double A2
        {
            get { return a2; }
            set { a2 = value; }
        }

        public double A0
        {
            get { return a0; }
            set { a0 = value; }
        }

        // Конструктор для ініціалізації коефіцієнтів прямої.
        public Line(double a1, double a2, double a0)
        {
            this.A1 = a1;
            this.A2 = a2;
            this.A0 = a0;
        }

        // Метод для виведення рівняння прямої.
        public void PrintEquation()
        {
            Console.WriteLine($"Рівняння прямої: {A1}x + {A2}y + {A0} = 0");
        }

        // Перевірка, чи належить точка прямій.
        public bool IsPointOnLine(double x, double y)
        {
            return Math.Abs(A1 * x + A2 * y + A0) < 1e-9;
        }
    }

    // Клас для опису гіперплощини у чотиривимірному просторі.
    class Hyperplane : Line
    {
        public double A3 { get; set; }
        public double A4 { get; set; }

        // Конструктор для ініціалізації коефіцієнтів гіперплощини.
        public Hyperplane(double a4, double a3, double a2, double a1, double a0)
            : base(a1, a2, a0)
        {
            this.A3 = a3;
            this.A4 = a4;
        }

        // Метод для виведення рівняння гіперплощини.
        public void PrintEquation()
        {
            Console.WriteLine($"Рівняння гіперплощини: {A4}x4 + {A3}x3 + {A2}x2 + {A1}x1 + {A0} = 0");
        }

        // Перевірка, чи належить точка гіперплощині.
        public bool IsPointOnHyperplane(double x1, double x2, double x3, double x4)
        {
            return Math.Abs(A4 * x4 + A3 * x3 + A2 * x2 + A1 * x1 + A0) < 1e-9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Приклад використання класу "Пряма".
            Line line = new Line(2, -3, 5);
            line.PrintEquation();
            Console.WriteLine($"Точка (1, 1) {(line.IsPointOnLine(1, 1) ? "належить" : "не належить")} прямій.");

            // Приклад використання класу "Гіперплощина".
            Hyperplane hyperplane = new Hyperplane(1, -1, 2, 3, -4);
            hyperplane.PrintEquation();
            Console.WriteLine($"Точка (1, 2, 3, 4) {(hyperplane.IsPointOnHyperplane(1, 2, 3, 4) ? "належить" : "не належить")} гіперплощині.");
        }
    }
}
