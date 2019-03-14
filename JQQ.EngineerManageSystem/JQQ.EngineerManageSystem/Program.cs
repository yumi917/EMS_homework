using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JQQ.EngineerManageSystem
{
    class Program
    {
        public static int count = 0;  //定义个全局变量 记录输入的工程师数量
        /// <summary>
        /// 系统登录
        /// </summary>
        public static void LoginEngineerSystem()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
            Console.WriteLine("\t\t☆\t\t\t\t\t\t☆");
            Console.WriteLine("\t\t☆\t\t※请输入用户名和密码※\t\t☆");
            Console.WriteLine("\t\t☆\t\t\t\t\t\t☆");
            Console.WriteLine("\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
            Console.Write("\n\t\t【UresName】:");
            string UName = Console.ReadLine();
            Console.Write("\n\t\t【P a s s w o r d】:");
            string PassWord = Console.ReadLine();
            if (UName == "2018173801" && PassWord == "123456")
            {
                EngineerManageSystem();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t密码或用户名错误！请重新输入");
                if (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    LoginEngineerSystem();
                }
            }
        }
        /// <summary>
        /// 工程师结构体
        /// </summary>
        public struct Engineer
        {
            public string eengineerID;				//工程师编号
            public string eengineerSex; 				//工程师性别
            public string eengineerEducation; 		//工程师教育背景
            public string eengineerName; 				//工程师姓名
            public string eengineerHometown; 			//工程师籍贯
            public string eengineerAddress; 			//工程师地址
            public string eengineerPhone; 			//工程师电话
            public string eengineerBirthday; 			//工程师生日

        }

        /// <summary>
        /// 输入工程师资料
        /// </summary>
        public static void InputEngineerInfo()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
            Console.WriteLine("\t\t※\t\t\t\t\t\t※\n\t\t※\t\t\t\t\t\t※");
            Console.WriteLine("\t\t※\t〖您已进入工程师资料输入系统〗\t\t※");
            Console.WriteLine("\t\t※\t\t\t\t\t\t※\n\t\t※\t\t\t\t\t\t※");
            Console.WriteLine("\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
            Console.WriteLine("\n\n\n\t\t\t\t◎按ESC键返回主菜单\n\n\t\t\t\t◎按任意键进入输入界面...");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                EngineerManageSystem();
            }
            else
            {
                for (int test=1;test!=0 ; )
                {
                    Console.Clear();
                    Console.WriteLine("\t\t〓〓〓〓〓〓〓〓〓〓〓〓  工程师资料输入系统  〓〓〓〓〓〓〓〓〓〓〓〓〓\n\n");
                    Console.WriteLine("\t\t\t\t\t→系统以前输入了{0}个工程师信息←\n\n", count);
                    Engineer[] Star = new Engineer[100];
                    Console.Write("\t\t\t【请输入工程师的编号】<01-99>：");
                    int num = int.Parse(Console.ReadLine());
                    Star[num - 1].eengineerID = num.ToString();
                    Console.Write("\t\t\t【请输入工程师的姓名】：");
                    Star[num - 1].eengineerName = Console.ReadLine();
                    Console.Write("\t\t\t【请输入工程师的性别】：");
                    Star[num - 1].eengineerSex = Console.ReadLine();
                    Console.Write("\t\t\t【请输入工程师的籍贯】：");
                    Star[num - 1].eengineerHometown = Console.ReadLine();
                    Console.Write("\t\t\t【请输入工程师的教育背景】：");
                    Star[num - 1].eengineerEducation = Console.ReadLine();
                    Console.Write("\t\t\t【请输入工程师的地址】：");
                    Star[num - 1].eengineerAddress = Console.ReadLine();
                    Console.Write("\t\t\t【请输入工程师的电话】：");
                    Star[num - 1].eengineerPhone = Console.ReadLine();
                    Console.Write("\t\t\t【请输入工程师的生日】：");
                    Star[num - 1].eengineerBirthday = Console.ReadLine();
                    count++;  //数量录入成功自加
                    /*这里可以清屏*/
                    Console.Clear();
                    Console.WriteLine("\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆您输入的信息如下☆☆☆☆☆☆☆☆☆☆☆☆");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t\t\t『编号』：{0}\t『姓名』：{1}\n", Star[num - 1].eengineerID, Star[num - 1].eengineerName);
                    Console.WriteLine("\t\t\t\t『性别』：{0}\t『籍贯』：{1}\n", Star[num - 1].eengineerSex, Star[num - 1].eengineerHometown);
                    Console.WriteLine("\t\t\t\t『学历』：{0}\t『电话』：{1}\n", Star[num - 1].eengineerEducation, Star[num - 1].eengineerPhone);
                    Console.WriteLine("\t\t\t\t『地址』：{0}\n", Star[num - 1].eengineerAddress);
                    Console.WriteLine("\t\t\t\t『出生日期』：{0}\n", Star[num - 1].eengineerBirthday);
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
                    Console.WriteLine("\t\t※以上信息如有要修必的地方请联系管理员修改※");
                    Console.WriteLine("\t\t\t◎回主菜单请按‘ESC’\t◎其它继续录入...");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        EngineerManageSystem();
                        //  添加test的作用是为了停止这个for循环
                        test = 0;                   
                    }
                    //如果没有按Esc则运行循环
                }
            }
        }

        /// <summary>
        /// 删除工程师资料
        /// </summary>
        public static void DeleteEngineerInfo()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
            Console.WriteLine("\t\t※\t\t\t\t\t\t※\n\t\t※\t\t\t\t\t\t※");
            Console.WriteLine("\t\t※\t〖您已进入工程师资料删除系统〗\t\t※");
            Console.WriteLine("\t\t※\t\t\t\t\t\t※\n\t\t※\t\t\t\t\t\t※");
            Console.WriteLine("\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
            Console.WriteLine("\n\n\n\t\t\t\t◎按ESC键返回主菜单\n\n\t\t\t\t◎按任意键进入删除界面...");

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                EngineerManageSystem();
            }
            else
            {
                for (int test = 1; test != 0;)
                {
                    Console.Clear();
                    //这是员工结构体
                    Engineer[] Star = new Engineer[100];
                    Console.WriteLine("\t\t〓〓〓〓〓〓〓〓〓〓〓〓  工程师资料删除系统  〓〓〓〓〓〓〓〓〓〓〓〓〓\n\n");
                    Console.WriteLine("\t\t\t\t\t→系统以前输入了{0}个工程师信息←\n\n", count);
                    Console.Write("\n\n\n\n\n\n\t\t\t『请输入要删除的工程师编号』：");
                    string DNum = Console.ReadLine();
                    for (int i = 0; i < 100; i++)
                    {
                        if (DNum != Star[i].eengineerID)
                        {
                            Console.WriteLine("\n\n\n\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
                            Console.WriteLine("\t\t☆\t\t\t\t\t\t☆");
                            Console.WriteLine("\t\t☆\t※编号为{0}的工程师不存在※\t\t☆",DNum);
                            Console.WriteLine("\t\t☆\t\t\t\t\t\t☆");
                            Console.WriteLine("\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
                            Console.WriteLine("\n\t\t\t\t◎按回车键返回主菜单");
                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                EngineerManageSystem();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\n\n\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
                            Console.WriteLine("\t\t☆\t\t\t\t\t\t☆");
                            Console.WriteLine("\t\t☆\t※确实要删除编号为{0}的信息吗※\t\t☆", DNum);
                            Console.WriteLine("\t\t☆\t\t\t\t\t\t☆");
                            Console.WriteLine("\t\t☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆");
                            Console.WriteLine("\n\t\t\t\t◎Y->『删除』\n\t\t\t\t◎其他->『不删除返回』");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                            {
                                EngineerManageSystem();
                            }
                            else
                            {
                                Star[i].eengineerID = null;
                                Star[i].eengineerName = null;
                                Star[i].eengineerSex = null;
                                Star[i].eengineerHometown = null;
                                Star[i].eengineerEducation = null;
                                Star[i].eengineerAddress = null;
                                Star[i].eengineerPhone = null;
                                Star[i].eengineerBirthday = null;
                                break;
                            }
                        }
                    }
                }

            }

        }

        /// <summary>
        /// 查询指定工程师资料
        /// </summary>
        public static void QueryEngineerInfo()
        {

        }

        /// <summary>
        /// 结束程序
        /// </summary>
        public static void LogoutEngineerSytstem()
        {
            Console.Clear();
            Console.WriteLine("程序结束！");
        }

        /// <summary>
        /// 菜单界面
        /// </summary>
        public static void EngineerManageSystem()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
            Console.WriteLine("\t\t〓\t\t\t\t\t\t〓");
            Console.WriteLine("\t\t〓\t\t∮工程师管理系统∮\t\t〓");
            Console.WriteLine("\t\t〓\t\t\t\t\t\t〓");
            Console.WriteLine("\t\t〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
            Console.WriteLine("\n\n\t\t\t【1】输入工程师资料");
            Console.WriteLine("\t\t\t【2】删除指定工程师资料");
            Console.WriteLine("\t\t\t【3】查询工程师资料");
            Console.WriteLine("\t\t\t【4】结束");
            Console.Write("〖请输入您要的选择〗：");
            string Number = Console.ReadLine();
            switch (Number)
            {
                case "1": InputEngineerInfo(); break;
                case "2": DeleteEngineerInfo(); break;
                case "3": QueryEngineerInfo(); break;
                case "4": LogoutEngineerSytstem(); break;
                default:
                    {
                        Console.WriteLine("您的输入有误，请重试！");
                        EngineerManageSystem();
                    }
                    break;
            }
        }

        /// <summary>
        /// 主函数
        /// </summary>
        static void Main(string[] args)
        {
            LoginEngineerSystem();
            //EngineerManageSystem();
            //InputEngineerInfo();
        }
    }
}
