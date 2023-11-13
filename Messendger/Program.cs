using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messendger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int password = 1234;
            Console.WriteLine("Авторизация");
            Console.WriteLine("Введите пароль");

            
                int enter = Convert.ToInt32(Console.ReadLine());
            if (enter == password)
            {
                Console.WriteLine("Добро пожаловать!");
            }
            else
            {
                Console.WriteLine("Не верно!");
            }

            Console.WriteLine("Ваши диалоги");
            Console.WriteLine("С кем вы желаете вступить в диалог");
            Console.WriteLine("1 - Босс");
            Console.WriteLine("2 - Папа");
            Console.WriteLine("3 - Серега");
            Console.WriteLine("4 - Лиза");
            Console.WriteLine("5 - Вова");

            string partner = Console.ReadLine();

            if (partner == "1")
            {
                Console.WriteLine("Открыт диалог с Босс");
                Console.WriteLine("Босс - Привет парень! Отлично поработал вчера! Что то срочное?");
                string answer = Console.ReadLine();
                Console.WriteLine("Босс - Извини парень, мне нужно ехать на переговоры. Напиши мне завтра!");
                string answer1 = Console.ReadLine();
                Console.WriteLine("Босс - Молодец Парень! Даю тебе надбавку 15% и отгул на завтра!");
                string answer2 = Console.ReadLine();
                Console.WriteLine("Босс - Поговорим о твоем повышении после моего отпуска! Пока!");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("Пользователь не в сети");

            }
            else if (partner == "2")
            {
                Console.WriteLine("Начните диалог");
                string daddy = Console.ReadLine();
                Console.WriteLine("Папа - Привет здоровяк! Как жизнь молодая?");
                string daddy1 = Console.ReadLine();
                Console.WriteLine("Папа - А у нас с матерью все по старому, огород, пчелки. Как дела на работе?");
                string daddy2 = Console.ReadLine();
                Console.WriteLine("Папа - Я же тебе говорил что надо было учится! Что там с твоим последним проэктом?");
                string daddy3 = Console.ReadLine();
                Console.WriteLine("Папа - Сынок, ты молодец! Я бы так точно не смог!");
                Console.WriteLine("Папа - Ладно, мать зовет, к кумовьям едем! Давай молодой! Ни пуха!");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("Пользователь не в сети");
            }
            else if (partner == "3")
            {
                Console.WriteLine("Начните диалог");
                string grey = Console.ReadLine();
                Console.WriteLine("Серега - Здарова! Че вчера не брал трубку!?");
                Console.WriteLine("Серега - Ты хоть помнишь че вчера было?");
                Console.WriteLine("Серега - Не парься писать текстом. 1 помнишь, 2 нет ");
                bool hochuZnat = true;
                int grey1 = Convert.ToInt32(Console.ReadLine());
                if (hochuZnat == true && grey1 < 2)
                {
                    Console.WriteLine("Я - Рассказывай!");
                }
                else
                {
                    Console.WriteLine("Я - Конечно помню");
                }
                Console.WriteLine("Серега - Вчера в баре ты у всех на глазах целовался с новенькой");
                Console.WriteLine("Как новенькая целуется? по 5 шкале :D");
                bool otvechu = true;
                int grey2 = Convert.ToInt32(Console.ReadLine());
                if (otvechu == true && grey2 < 5)
                {
                    Console.WriteLine("Я - Неплохо");
                    Console.WriteLine("Серега - Ну ты даешь друг! Лизку отшить, она ж красотка!");
                    Console.WriteLine("Ладно, пора по делам ехать");
                    Console.WriteLine("Давай, удачи!");
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    Console.WriteLine("Пользователь не в сети");
                }
                else
                {
                    Console.WriteLine("Я - Это ты был пьяный и все напутал!");
                    Console.WriteLine("Серега - Ну-ну. Да-да-да!)))");
                    Console.WriteLine("Серега - Смотри чтоб Лизка не просекла! Давай, до вечера!");
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    Console.WriteLine("Пользователь не в сети");
                }


            }
            else if (partner == "4")
            {
                Console.WriteLine("Открыт Диалог с Лиза");
                Console.WriteLine("Лиза - Привет малыш! Как вчера провел время?");
                string lisa = Console.ReadLine();
                Console.WriteLine("Лиза - Погоди, ответь мне сразу: вы с Серегой вчера выпили по 1 порции как ты мне говорил или больше 1?");
                bool pravda = true;
                int lisa1 = Convert.ToInt32(Console.ReadLine());
                if (pravda == true && lisa1 == 2)
                {
                    Console.WriteLine("Лиза - Ты мой зайка. Напился и пошел спать :3");
                    Console.WriteLine("Лиза - Завтра могу приехать к тебе с ночевкой!");
                    string lisa2 = Console.ReadLine();
                    Console.WriteLine("Лиза - Все! Завтра у тебя в 8! И не забудь купить мое любимое вино!");
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    Console.WriteLine("Пользователь не в сети");
                }
                else
                {
                    Console.WriteLine("Лиза - Ты меня за дуру здесь держишь");
                    Console.WriteLine("Лиза - Еще скажи что ты не целовался с новенькой у всех на глазах!");
                    Console.WriteLine("Лиза - Тут одно из двух");
                    Console.WriteLine("Лиза - 1 - я тебе надоела и ты ищешь новую игрушку");
                    Console.WriteLine("Лиза - 2 - ты настолько наивен что думал я начну ревновать");
                    bool nadoela = false;
                    int lisa3 = Convert.ToInt32(Console.ReadLine());
                    if (nadoela == false && lisa3 == 2)
                    {
                        Console.WriteLine("Лиза - Ладно, дурачек. Позвони мне вечером, я на работе сейчас");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("Пользователь не в сети");
                    }
                    else
                    {
                        Console.WriteLine("Лиза - между нами все кончено!!!");
                        Console.WriteLine("Лиза - не пиши мне и не звони");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("Пользователь не в сети");

                    }

                }


            }
            else if (partner == "5")
            {
                Console.WriteLine("Открыт диалог с Вова");
                Console.WriteLine("Администрация президента Украины Владимира Зеленского");
                Console.WriteLine("С кем вас соединить?");
                Console.WriteLine("1 - Владимир Зеленский");
                Console.WriteLine("2 - Алексей Арестович");
                bool president = false;
                int vova = Convert.ToInt32(Console.ReadLine());
                if (president == false && vova == 1)
                {
                    Console.WriteLine("Президент занят и не может ответить на ваше сообщение");
                    Console.WriteLine("Напишите что ему передать");
                    string vova1 = Console.ReadLine();
                    Console.WriteLine("Мы все записали и президент прочтет это завтра утром");
                    Console.WriteLine("Слава Украине");
                    string vova2 = Console.ReadLine();
                    Console.WriteLine("Слава Нации");
                    string vova3 = Console.ReadLine();
                    Console.WriteLine("Путин - ");
                    string vova4 = Console.ReadLine();
                    Console.WriteLine("Все буде");
                    string vova5 = Console.ReadLine();
                    Console.WriteLine("Вы настоящий патриот!");
                    Console.WriteLine("Украина понад усе!");

                }
                else
                {
                    Console.WriteLine("Алексей - Я Арестович! Я все знаю! Спрашивай!");
                    string arest = Console.ReadLine();
                    Console.WriteLine("Алексей - Война в Украине закончится летом! ну или осенью, тут сложно сказать");
                    Console.WriteLine("Алексей - Я занят! Потом поговорим.");
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    Console.WriteLine("Пользователь не в сети");
                }






            }
            else
            {
                Console.WriteLine("Error");
            } 
            Console.ReadKey();
            
            















        }
    }
}
