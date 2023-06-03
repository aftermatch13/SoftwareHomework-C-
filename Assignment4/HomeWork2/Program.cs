using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp210_22
{
    // 定义委托 函数的类型 它的主要作用是 指定了事件处理方法必须拥有的返回类型和参数
    public delegate void MessageHandler(string messageText, int num);

    public class Connection
    {
        // 定义事件 指定要使用的委托类型。
        // 这种方式声明了事件后，就可以引发它（使用和委托触发的方法）。理解：他是一个其返回类型和参数是由委托指定的方法一样。通过方法的调用来引用事件
        public event MessageHandler MessageArrived;
        private Timer pollTimer;

        public Connection()
        {
            pollTimer = new Timer(1000);
            pollTimer.Elapsed += new ElapsedEventHandler(checkForMessage);
        }

        public void Connect()
        {
            pollTimer.Start();
        }
        public void Disconnect()
        {
            pollTimer.Stop();

        }
        private static Random random = new Random();
        private void checkForMessage(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Checking for new message");
            //  这个表达式也使用了委托语法，其含义是 “事件是否有订阅者”，如果没有订阅者，也就不会触发事件
            if ((random.Next(9) == 0) && (MessageArrived != null))
            {
                // 这里的作用是触发事件，触发事件以后，他会将参数传递给他绑定的事件处理器
                MessageArrived("Hello", random.Next(9));
            }
        }
    }

    // 订阅事件的额类
    public class Dispaly
    {
        public void DisplayMessage(string message, int num)
        {
            Console.WriteLine("Message arrievd:{0}:{1}", message, num);

        }
    }
    class Program
    {
        // 定义委托规则
        static void Main(string[] args)
        {
            Connection myconnection = new Connection();
            Dispaly mydissplay = new Dispaly();
            // 事件订阅  当这个事件被触发以后，执行事件处理器（一段执行逻辑代码） 那他到底是怎么被处罚的呢？（见上面注释）
            myconnection.MessageArrived += new MessageHandler(mydissplay.DisplayMessage);
            myconnection.Connect();
            Console.ReadKey();
        }

    }
}

