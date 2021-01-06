using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_观察者设计模式_猫捉老鼠
{
    //老鼠为观察者，观察者类
    class Mouse
    {
        private string name;
        private string color;

        public Mouse(string name,string color,Cat cat)
        {
            this.name = name;
            this.color = color;
            cat.catCome += this.RunAway;//把自身的逃跑方法 注册进 猫里面 订阅消息
        }

        //逃跑功能
        public void RunAway()
        {
            Console.WriteLine(color+"的老鼠"+name+"说：老猫来了，赶紧跑，我跑，我使劲跑，我加速使劲跑。。。");
        }

    }
}
