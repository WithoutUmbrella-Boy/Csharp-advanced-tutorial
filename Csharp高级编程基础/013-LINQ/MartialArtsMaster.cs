using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _013_LINQ
{
    //武林高手
     class MartialArtsMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Menpai { get; set; }
        public string Kongfu { get; set; }
        public int Level { get; set; }


        //ReSharper  插件下快捷键Alt+Insert快捷键下的formatting mumber可以快捷生成格式化数据
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(Menpai)}: {Menpai}, {nameof(Kongfu)}: {Kongfu}, {nameof(Level)}: {Level}";
        }

    }


}