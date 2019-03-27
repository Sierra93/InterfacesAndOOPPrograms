////Создать абстрактный класс Figure с методами вычисления площади и периметра, а также методом, выводящим информацию о фигуре на экран.
////Создать производные классы: Rectangle(прямоугольник), Circle(круг), Triangle(треугольник) со своими методами вычисления площади и периметра.
////Создать массив n фигур и вывести полную информацию о фигурах на экран.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleProgramsOOP {
//    class Program {
//        static void Main(string[] args) {
//            Rectangle p = new Rectangle();
//            p.Perimetr();
//            Rectangle s = new Rectangle();
//            s.Ploshad();
//            Console.ReadKey();
//        }
//    }
//    //абстрактный класс фигуры
//    public abstract class Figure {
//        public abstract void Perimetr();    //метод вычисляющий периметр 
//        public abstract void Ploshad(); //метод вычисляющий площадь
//        public abstract void InfoFigurs();  //метод вывода информации о фигуре 
//        public int[] infoFigurs = new int[50];
//    }
//    //класс прямоугольник
//    public class Rectangle : Figure {
//        public override double Perimetr(double a, double b, double c, double p) {
//            return p = a + b + c;  //вычисление периметра треугольника
//        }
//        public override void Ploshad() {
//            double b = 2, h = 4, s;
//            s = 1 / 2 * b * h;  //вычисление площади треугольника
//        }
//        public override void InfoFigurs() {

//        }
//    }
//}
using System;
using System.Globalization;

namespace AbstractFigure {
    internal class Program {
        private static void Main() {
            Figure figure1 = new Triangle(4, 5, 6);
            figure1.ShowInfo();

            Figure figure2 = new Rectangle(5, 6);
            figure2.ShowInfo();

            Console.ReadLine();
        }
        internal abstract class Figure {
            public abstract string Area();
            public abstract string Perimeter();
            public abstract string ShapeName();

            public void ShowInfo() {
                Console.WriteLine(
                    $"Название фигуры: {ShapeName()}\n" +
                    $"Площадь: {Area()}\n" +
                    $"Периметр: {Perimeter()}"
                );
                Console.WriteLine();
            }
        }
        internal class Rectangle : Figure {
            private double width;   // Ширина прямоугольника
            private double height;   // Высота прямоугольника

            // Конструктор
            public Rectangle(double rectangleWidth, double rectangleHeight) {
                Width = rectangleWidth;
                Height = rectangleHeight;
            }

            // Свойство, проверяем значение на отрицательность.
            public double Width {
                get => width;
                set => width = value < 0 ? -value : value;
            }

            public double Height {
                get => height;
                set => height = value < 0 ? -value : value;
            }

            // Метод для вычисления площади прямоугольника
            public override string Area() {
                return (width * height).ToString(CultureInfo.InvariantCulture);
            }

            // Метод для вычисления периметра прямоугольника
            public override string Perimeter() {
                return (width * 2 + height * 2).ToString(CultureInfo.InvariantCulture);
            }

            // Метод возвращающий наименование фигуры
            public override string ShapeName() {
                return "Прямоугольник";
            }
        }
        internal class Triangle : Figure {
            private double sideA, sideB, sideC;   // Стороны треугольника

            // Конструктор
            public Triangle(double triangleSideA, double triangleSideB, double triangleSideC) {
                SideA = triangleSideA;
                SideB = triangleSideB;
                SideC = triangleSideC;
            }

            // Свойство, проверяем значение на отрицательность.
            // Если значение отрицательное меняем его на аналогичное положительное.
            public double SideA {
                get => sideA;
                set => sideA = value < 0 ? -value : value;
            }

            public double SideB {
                get => sideB;
                set => sideB = value < 0 ? -value : value;
            }

            public double SideC {
                get => sideC;
                set => sideC = value < 0 ? -value : value;
            }

            // Метод для вычисления площади треугольника
            public override string Area() {
                double semPer = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString(CultureInfo.InvariantCulture);
            }

            // Метод для вычисления периметра треугольника
            public override string Perimeter() {
                return (sideA + sideB + sideC).ToString(CultureInfo.InvariantCulture);
            }

            // Метод возвращающий наименование фигуры
            public override string ShapeName() {
                return "Треугольник";
            }
        }
    }
}