using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace Telegram_Bot
{
    class Program
    {
        static readonly TelegramBotClient Bot = new TelegramBotClient("1383965120:AAGDz1c9I_H9f40zcDa15D8jYdT1uVBQgNs");
        
        static void Main(string[] args)
        {
            Bot.StartReceiving();
            Bot.OnMessage += Bot_OnMessage;
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                Commands(e);
        }
        public static void Commands(MessageEventArgs e)
        {
            TimeSpan morning = new TimeSpan(3, 0, 0);
            TimeSpan afternoon = new TimeSpan(12, 0, 0);
            TimeSpan evening = new TimeSpan(18, 0, 0);
            var now = DateTime.Now.TimeOfDay;
            var location = e.Message.Location;


            if (e.Message.Text.ToLower() == "hi")
            {
                if (now >= morning && now < afternoon)
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Good morning " + e.Message.Chat.FirstName + "," + Environment.NewLine + "How may I help you?");
                else if (now >= afternoon && now < evening)
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Good afernoon " + e.Message.Chat.FirstName + "," + Environment.NewLine + "How may I help you?");
                else
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Good evening " + e.Message.Chat.FirstName + "," + Environment.NewLine + "How may I help you?");
            }

            if (e.Message.Text.ToLower() == "/help")
            {
                Bot.SendTextMessageAsync(e.Message.Chat.Id, "Here is the list of commands:");
                Bot.SendTextMessageAsync(e.Message.Chat.Id, "/coinflip" + Environment.NewLine + "/random" + Environment.NewLine + "/d4" + Environment.NewLine + "/d6" + Environment.NewLine + "/d8" + Environment.NewLine + "/d10" + Environment.NewLine + "/d12" + Environment.NewLine + "/d20");
            }

            if (e.Message.Text.ToLower() == "/d4")
            {
                Random rand_num = new Random();
                int rand_result = 0;
                {
                    lock (rand_num)
                    {
                        rand_result = rand_num.Next(1,5);
                    }

                    if (rand_result == 4)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical hit!");
                    }
                    else if (rand_result == 1)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical failure!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}");
                    }

                }

            }

            if (e.Message.Text.ToLower() == "/d6")
            {
                Random rand_num = new Random();
                int rand_result = 0;
                {
                    lock (rand_num)
                    {
                        rand_result = rand_num.Next(1, 7);
                    }

                    if (rand_result == 6)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical hit!");
                    }
                    else if (rand_result == 1)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical failure!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}");
                    }

                    
                }

            }

            if (e.Message.Text.ToLower() == "/d8")
            {
                Random rand_num = new Random();
                int rand_result = 0;
                {
                    lock (rand_num)
                    {
                        rand_result = rand_num.Next(1, 9);
                    }

                    if (rand_result == 8)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical hit!");
                    }
                    else if (rand_result == 1)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical failure!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}");
                    }
                }

            }

            if (e.Message.Text.ToLower() == "/d10")
            {
                Random rand_num = new Random();
                int rand_result = 0;
                {
                    lock (rand_num)
                    {
                        rand_result = rand_num.Next(1, 11);
                    }

                    if (rand_result == 10)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical hit!");
                    }
                    else if (rand_result == 1)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical failure!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}");
                    }
                }

            }

            if (e.Message.Text.ToLower() == "/d12")
            {
                Random rand_num = new Random();
                int rand_result = 0;
                {
                    lock (rand_num)
                    {
                        rand_result = rand_num.Next(1, 13);
                    }

                    if (rand_result == 12)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical hit!");
                    }
                    else if (rand_result == 1)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical failure!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}");
                    }

                }

            }

            if (e.Message.Text.ToLower() == "/d20")
            {
                Random rand_num = new Random();
                int rand_result = 0;
                {
                    lock (rand_num)
                    {
                        rand_result = rand_num.Next(1, 21);
                    }

                    if (rand_result == 20)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical hit!");
                    }
                    else if (rand_result == 1)
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}. Critical failure!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Your number is: " + $"{rand_result}");
                    }

                }

            }

            if (e.Message.Text.ToLower() == "/coinflip")
            {
                CoinFlip(e);
            }

        }

        private static void CoinFlip(MessageEventArgs e)
        {
            Random coinflip = new Random();
            int result = 0;

            result = coinflip.Next(0, 2);

            if (result == 1)
            {
                Bot.SendTextMessageAsync(e.Message.Chat.Id, "You flipped a coin and it landed on " + "*heads*", ParseMode.MarkdownV2);
            }
            else
            {
                Bot.SendTextMessageAsync(e.Message.Chat.Id, "You flipped a coin and it landed on " + "*tails*", ParseMode.MarkdownV2);
                
            }
        }
    }
}
