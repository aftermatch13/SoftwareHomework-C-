using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        abstract class Shape
        {
            //面积计算
            public abstract double Area();
            //初始化数据以及判断是否合法
            public abstract void Initialization();
        }



        //三角形的创建
        class Triangle : Shape
        {
            double side1;
            double side2;
            double side3;
            public Triangle()
            {
                Initialization();
            }
            public override double Area()
            {
                double area2 = ((side1 + side2 + side3) / 2 - side1) * ((side1 + side2 + side3) / 2 - side2) * ((side1 + side2 + side3) / 2 - side3) * (side1 + side2 + side3) / 2;
                double area = Math.Pow(area2, 1.0 / 2);
                return area;
            }
            public override void Initialization()
            {
                while (true)
                {
                    Console.WriteLine("请输入三角形第一条边的长度：");
                    string side1Str = Console.ReadLine();
                    Console.WriteLine("请输入三角形第二条边的长度：");
                    string side2Str = Console.ReadLine();
                    Console.WriteLine("请输入三角形第三条边的长度：");
                    string side3Str = Console.ReadLine();
                    if (!double.TryParse(side1Str, out side1) || !double.TryParse(side2Str, out side2) || !double.TryParse(side3Str, out side3))
                    {
                        Console.WriteLine("输入数据出现非法字符，请重新输入！！！");
                        continue;

                    }
                    if (side1<0 || side2<0 || side3<0 || side1 + side2 <= side3 || side1 + side3 <= side2 || side3 + side2 <= side1)
                    {
                        Console.WriteLine("输入的三角形不合法，请重新输入！！！");
                        continue;

                    }
                    break;
                }
            }
        }



        //长方形的创建
        class Rectangle : Shape
        {
            double height;
            double width;
            public Rectangle()
            {
                Initialization();
            }
            public override double Area()
            {
                double area = height * width;
                return area;
            }

            public override void Initialization()
            {
                while (true)
                {

                    Console.WriteLine("请输入长方形的长：");
                    string heightStr = Console.ReadLine();
                    Console.WriteLine("请输入长方形的宽：");
                    string widthStr = Console.ReadLine();
                    if (!double.TryParse(heightStr, out height) || !double.TryParse(widthStr, out width))
                    {
                        Console.WriteLine("输入数据出现非法字符，请重新输入！！！");
                        continue;
                    }
                    if (height < 0 || width < 0)
                    {
                        Console.WriteLine("输入的数据不合法，请重新输入！！！");
                        continue;
                    }
                    break;
                }
            }

            //正方形的创建
            class Square : Shape
            {
               
                double width;
                public Square()
                {
                    Initialization();
                }
                public override double Area()
                {
                    double area = width * width;
                    return area;
                }

                public override void Initialization()
                {
                    while (true)
                    {

                        Console.WriteLine("请输入正方形的边长：");
                        string widthStr = Console.ReadLine();                
                        if ( !double.TryParse(widthStr, out width))
                        {
                            Console.WriteLine("输入数据出现非法字符，请重新输入！！！");
                            continue;
                        }
                        if (width < 0)
                        {
                            Console.WriteLine("输入的数据不合法，请重新输入！！！");
                            continue;
                        }
                        break;
                    }
                }
                //圆形的创建
                class Circle : Shape
                {
                    double r;
                    public Circle()
                    {
                        Initialization();
                    }
                    public override double Area()
                    {
                        double area = Math.PI * r * r;
                        return area;
                    }
                    public override void Initialization()
                    {
                        while (true)
                        {
                            Console.WriteLine("请输入圆的半径：");
                            string rStr = Console.ReadLine();
                            if (!double.TryParse(rStr, out r))
                            {
                                Console.WriteLine("输入数据出现非法字符，请重新输入！！！");
                                continue;
                            }
                            if(r < 0)
                            {
                                Console.WriteLine("输入的数据不合法，请重新输入！！！");
                                continue;
                            }
                            break;
                        }
                    }
                }





                //工厂
                class Factory
                {
                    public static Shape CreatFuncition(string name)
                    {
                        switch (name)
                        {
                            case "1": return new Triangle();
                            case "2": return new Rectangle();
                            case "3": return new Square();
                            case "4": return new Circle();
                            default:
                                return null;
                        }
                    }
                }
                static void Main(string[] args)
                {
                    double totalarea = 0.000;
                    for(int i = 1; i < 11; i++)
                    {
                        Console.WriteLine("第{0}次创建图形",i);
                       
                        while (true)
                        {
                            Console.WriteLine("请创建图形：");
                            Console.WriteLine("1、三角形  2、长方形 3、正方形 4、圆形 ");
                            string name = Console.ReadLine();
                            Shape shape = Factory.CreatFuncition(name);
                            if (shape == null)
                            {
                                Console.WriteLine("找不到对应的图形，请重新选择。");
                                continue;
                            }
                            double a = shape.Area();
                            Console.WriteLine("该图形面积为：{0}", a);                                 
                            totalarea += a;
                            break;
                        }
                        Console.WriteLine("按任意键继续......");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    Console.WriteLine("十个图形总面积为：{0}",totalarea);
                }
            }
        }
    }
}

