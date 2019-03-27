using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndOOPPrograms {
    //создание двух интерфейсов, описывающих абстрактные методы арифметических операций и операций Sqr и Sqrt
    public interface IArrOperations {
        //определяем набор абстрактных методов
        int Sum();
        int Otr();
        int Prz();
        int Del();
    }
    public interface ISqrSqrt {
        int Sqr(int x);
        int Sqrt(int x);
    }
    //этот класс реализует интерфейс IArOperation
    class A : IArrOperations {
        int myX, myY;
        public int x {
            set { myX = value; }
            get { return myX; }
        }
        public int y {
            set { myY = value; }
            get { return myY; }
        }
        public A() { }
        public A(int x, int y) {
            this.x = x;
            this.y = y;
        }
        //реализуем методы интерфейса
        public virtual int Sum() {
            return x + y;
        }
        public int Otr() {
            return x - y;
        }
        public int Prz() {
            return x * y;
        }
        public int Del() {
            return x / y;
        }
        //реализуем собственные методы у этого класса
        public virtual void Rewrite() {
            Console.WriteLine("Переменная x: {0} \nПеременная y: {1}", x, y);
        }
    }
    //наследуемся от класса А, и можем переопределить некоторые его методы
    class Aa : A {
        public int z;
        public Aa (int z, int x, int y) : base (x, y) {
            this.z = z;
        }
        //переопределяем метод Sum
        public override int Sum() {
            return x + y + z;
        }
        public override void Rewrite() {
            Console.WriteLine("Переменная z: " + z);
        }
    }
    //наследуемся от класса А и реализуем интерфейс ISqrSqrt
    class Ab : A, ISqrSqrt {
        public int Sqr(int x) {
            return x * x;
        }
        public int Sqrt(int x) {
            return (int)Math.Sqrt(x);
        }
    }
    class Program {
        static void Main(string[] args) {
            A obj1 = new A(x: 10, y: 12);
            Console.WriteLine("obj1: ");
            obj1.Rewrite();
            Console.WriteLine("{0} + {1} = {2}", obj1.x, obj1.y, obj1.Sum());
            Console.WriteLine("{0} * {1} = {2}", obj1.x, obj1.y, obj1.Prz());
            Aa obj2 = new Aa(z: -3, x: 10, y: 14);
            Console.WriteLine("\nobj2: ");
            obj2.Rewrite();
            Console.WriteLine("{0} + {1} + {3} = {2}", obj2.x, obj2.y, obj2.Sum(), obj2.z);
            Console.ReadKey();
        }
    }
}
