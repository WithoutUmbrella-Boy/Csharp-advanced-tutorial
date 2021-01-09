using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化武林高手
            var masterList = new List<MartialArtsMaster>(){
    new MartialArtsMaster(){ Id = 1, Name = "黄蓉",    Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 9  },
    new MartialArtsMaster(){ Id = 2, Name = "洪七公",  Age = 70, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 10 },
    new MartialArtsMaster(){ Id = 3, Name = "郭靖",    Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌",Level = 10 },
    new MartialArtsMaster(){ Id = 4, Name = "任我行",  Age = 50, Menpai = "明教", Kongfu = "葵花宝典",  Level = 1  },
    new MartialArtsMaster(){ Id = 5, Name = "东方不败",Age = 35, Menpai = "明教", Kongfu = "葵花宝典",  Level = 10 },
    new MartialArtsMaster(){ Id = 6, Name = "林平之",  Age = 23, Menpai = "华山", Kongfu = "葵花宝典",  Level = 7  },
    new MartialArtsMaster(){ Id = 7, Name = "岳不群",  Age = 50, Menpai = "华山", Kongfu = "葵花宝典",  Level = 8  },
    new MartialArtsMaster() { Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 },
    new MartialArtsMaster() { Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8 },
    new MartialArtsMaster() { Id =10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10 },
    new MartialArtsMaster() { Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 }
};
            //初始化武学
            var kongfuList = new List<Kongfu>(){
            new Kongfu(){KongfuId=1, KongfuName="打狗棒法", Lethality=90},
            new Kongfu(){KongfuId=2, KongfuName="降龙十八掌", Lethality=95},
            new Kongfu(){KongfuId=3, KongfuName="葵花宝典", Lethality=100},
            new Kongfu() { KongfuId=  4, KongfuName = "独孤九剑", Lethality = 100 },
            new Kongfu() { KongfuId = 5, KongfuName = "九阴真经", Lethality = 100 },
            new Kongfu() { KongfuId = 6, KongfuName = "弹指神通", Lethality = 100 }
        };


            //查询所有武学级别大于8的武林高手
            //var res = new List<MartialArtsMaster>();
            //foreach (var temp in masterList)
            //{
            //    if (temp.Level>8)
            //    {
            //        res.Add(temp);
            //    }
            //}

            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}

            //Console.ReadKey();



            //使用LINQ做查询（表达式写法）
            //var res = from m in masterList //from后面设置查询的集合
            //          where m.Level > 8 && m.Menpai=="丐帮" //where后面跟上查询的条件
            //          select m;//表示m的结果集合返回

            //扩展方法的写法
            //var res =  masterList.Where(Test1);

            //Lambda表达式写法
            var res = masterList.Where(m=>m.Level>8 && m.Menpai == "丐帮");       
            foreach (var temp in res)
            {
                Console.WriteLine(temp);
            }

            Console.ReadKey();
        }

        //扩展方法的过滤方法
        static bool Test1(MartialArtsMaster master)
        {
            if (master.Level > 8) return true;
            return false;

        }
    }
}
