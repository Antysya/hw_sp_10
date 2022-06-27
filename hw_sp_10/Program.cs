using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Console;

namespace hw_sp_10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("\nВыберите способ регистарции:\n1. по адресу электронной почты;\n" +
                "2. по номеру телефона;\n3. по номеру машины.\n" +
                "4. Выйти без регистрации.");
                string pos = ReadLine();
                switch (pos)
                {
                    case "1":
                        {
                            string emailPattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
                            WriteLine("Введите e-mail");
                            string email = ReadLine();
                            Regex reg = new Regex(emailPattern);
                            WriteLine(reg.IsMatch(email) ? "E-mail - принят. Вы успешно зарегистрированы" : "Ошибка, проверьте" +
                                $"введенный e-mail {email}");
                        }
                        break;

                    case "2":
                        {
                            string phonePattern = @"^\+\d{1,3}\(\d{3}\)\d{3}-\d{2}-\d{2}$";
                            WriteLine("Введите телефон в формате: +*(***)***-**-**");
                            string phone = ReadLine();
                            Regex reg1 = new Regex(phonePattern);
                            WriteLine(reg1.IsMatch(phone) ? "Телефон - принят. Вы успешно зарегистрированы" : "Ошибка,проверьте" +
                                $"введенный телефонный номер {phone}");
                        }
                        break;
                    case "3":
                        {
                            string numPattern = @"^[У,К,Е,Н,Х,В,А,Р,О,С,М,Т,E,T,O,P,Y,A,H,K,X,C,B,M]{1}\d{3}[У,К,Е,Н,Х,В,А,Р,О,С,М,Т,E,T,O,P,Y,A,H,K,X,C,B,M]{2}\d{2,3}RUS$";
                            WriteLine("Введите номер ТС:");
                            string number = ReadLine();
                            Regex reg2 = new Regex(numPattern);
                            WriteLine(reg2.IsMatch(number) ? "Номер - принят. Вы успешно зарегистрированы" : "Ошибка, проверьте" +
                                $"введенный номер {number}");

                        }
                        break;

                    case "4":
                        return;

                    default:
                        WriteLine("Вы выбрали несуществующий пункт меню. Выберите снова.");
                        continue;
                }
            }
        }
    }
}

