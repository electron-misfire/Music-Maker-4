namespace Music_creator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Media;
    using System.Threading;

    internal class Program
    {
        private static SoundPlayer a = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\a.wav");
        private static SoundPlayer a2 = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\2a.wav");
        private static SoundPlayer b = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\b.wav");
        private static SoundPlayer b2 = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\2b.wav");
        private static SoundPlayer c = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\c.wav");
        private static SoundPlayer c2 = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\2c.wav");
        private static int cursLeft;
        private static int cursorPos;
        private static SoundPlayer d = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\d.wav");
        private static SoundPlayer d0 = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\0d.wav");
        private static SoundPlayer e = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\e.wav");
        private static SoundPlayer e0 = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\0e.wav");
        private static SoundPlayer f = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\f.wav");
        private static SoundPlayer f0 = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\0f.wav");
        private static int fileName;
        private static SoundPlayer g = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\g.wav");
        private static SoundPlayer g0 = new SoundPlayer(@"D:\School\IT\Programming\Music creator\Music creator\0g.wav");
        private static string inFileName;
        private static List<string> line1 = new List<string>();
        private static List<string> line2 = new List<string>();
        private static List<string> line3 = new List<string>();
        private static List<string> line4 = new List<string>();
        private static List<string> line5 = new List<string>();
        private static List<string> line6 = new List<string>();
        private static List<string> line7 = new List<string>();
        private static Program music = new Program();
        private static char noteDuration = Convert.ToChar("c");
        private static string noteValue = "a";
        private static List<string> play = new List<string>();
        private static List<string> saveList = new List<string>();
        private static string userName;

        private void barLine()
        {
            line1.Add(" ");
            line2.Add(" ");
            line3.Add("|");
            line4.Add("|");
            line5.Add("|");
            line6.Add("|");
            line7.Add(" ");
            saveList.Add("||");
        }

        private void clear()
        {
            play.Clear();
            line1.Clear();
            line2.Clear();
            line3.Clear();
            line4.Clear();
            line5.Clear();
            line6.Clear();
            line7.Clear();
        }

        private void delete(int back)
        {
            try
            {
                back = line1.Count<string>() - back;
                line1.RemoveAt(back);
                back = line2.Count<string>() - back;
                line2.RemoveAt(back);
                back = line3.Count<string>() - back;
                line3.RemoveAt(back);
                back = line4.Count<string>() - back;
                line4.RemoveAt(back);
                back = line5.Count<string>() - back;
                line5.RemoveAt(back);
                back = line6.Count<string>() - back;
                line6.RemoveAt(back);
                back = line7.Count<string>() - back;
                line7.RemoveAt(back);
                back = play.Count<string>() - back;
                play.RemoveAt(back);
            }
            catch
            {
                Console.WriteLine("Sorry, please try that again");
            }
        }

        private void disp0D()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("____");
            line4.Add("____");
            line5.Add("__|_");
            line6.Add("__|_");
            line7.Add("_O|_");
            play.Add("d0");
            saveList.Add("d0");
        }

        private void disp0E()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("____");
            line4.Add("__|_");
            line5.Add("__|_");
            line6.Add("_ |_");
            line7.Add(" \x00ba  ");
            play.Add("e0");
            saveList.Add("e0");
        }

        private void disp0F()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("____");
            line4.Add("__|_");
            line5.Add("__|_");
            line6.Add("_O|_");
            line7.Add("    ");
            play.Add("f0");
            saveList.Add("f0");
        }

        private void disp0G()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("__|_");
            line4.Add("__|_");
            line5.Add("_ |_");
            line6.Add("_\x00ba__");
            line7.Add("    ");
            play.Add("g0");
            saveList.Add("g0");
        }

        private void disp2A()
        {
            line1.Add("_  _");
            line2.Add("_|\x00ba_");
            line3.Add("_|__");
            line4.Add("_|__");
            line5.Add("____");
            line6.Add("____");
            line7.Add("    ");
            play.Add("a2");
            saveList.Add("a2");
        }

        private void disp2B()
        {
            line1.Add("_|O_");
            line2.Add("_|__");
            line3.Add("_|__");
            line4.Add("____");
            line5.Add("____");
            line6.Add("____");
            line7.Add("    ");
            play.Add("b2");
            saveList.Add("b2");
        }

        private void disp2C()
        {
            line1.Add("_|\x00ba_");
            line2.Add("_|__");
            line3.Add("_|__");
            line4.Add("____");
            line5.Add("____");
            line6.Add("____");
            line7.Add("    ");
            play.Add("c2");
        }

        private void dispA()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("__|_");
            line4.Add("__|_");
            line5.Add("_O|_");
            line6.Add("____");
            line7.Add("    ");
            play.Add("a");
            saveList.Add("a");
        }

        private void dispB()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("__|_");
            line4.Add("_ |_");
            line5.Add("_\x00ba__");
            line6.Add("____");
            line7.Add("    ");
            play.Add("b");
            saveList.Add("b");
        }

        private void dispC()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("____");
            line4.Add("_|O_");
            line5.Add("_|__");
            line6.Add("_|__");
            line7.Add("    ");
            play.Add("c");
            saveList.Add("c");
        }

        private void dispD()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("_  _");
            line4.Add("_|\x00ba_");
            line5.Add("_|__");
            line6.Add("_|__");
            line7.Add("    ");
            saveList.Add("d0");
            play.Add("d");
        }

        private void dispE()
        {
            line1.Add("    ");
            line2.Add("____");
            line3.Add("_|O_");
            line4.Add("_|__");
            line5.Add("_|__");
            line6.Add("____");
            line7.Add("    ");
            play.Add("e");
            saveList.Add("e");
        }

        private void dispF()
        {
            line1.Add("    ");
            line2.Add("_  _");
            line3.Add("_|\x00ba_");
            line4.Add("_|__");
            line5.Add("_|__");
            line6.Add("____");
            line7.Add("    ");
            play.Add("f");
            saveList.Add("f");
        }

        private void dispG()
        {
            line1.Add("    ");
            line2.Add("_|O_");
            line3.Add("_|__");
            line4.Add("_|__");
            line5.Add("____");
            line6.Add("____");
            line7.Add("    ");
            play.Add("g");
            saveList.Add("g");
        }

        private void dispScore()
        {
            Console.Clear();
            music.startDisplay();
            try
            {
                for (int i = 0; i < (line1.Count - 1); i++)
                {
                    Console.Write(line1[i]);
                    music.newLine(7);
                }
                Console.WriteLine(line1[line1.Count - 1]);
                for (int j = 0; j < (line2.Count - 1); j++)
                {
                    Console.Write(line2[j]);
                }
                Console.WriteLine(line2[line2.Count - 1]);
                for (int k = 0; k < (line3.Count - 1); k++)
                {
                    Console.Write(line3[k]);
                }
                Console.WriteLine(line3[line3.Count - 1]);
                for (int m = 0; m < (line4.Count - 1); m++)
                {
                    Console.Write(line4[m]);
                }
                Console.WriteLine(line4[line4.Count - 1]);
                for (int n = 0; n < (line5.Count - 1); n++)
                {
                    Console.Write(line5[n]);
                }
                Console.WriteLine(line5[line5.Count - 1]);
                for (int num6 = 0; num6 < (line6.Count - 1); num6++)
                {
                    Console.Write(line6[num6]);
                }
                Console.WriteLine(line6[line6.Count - 1]);
                for (int num7 = 0; num7 < (line7.Count - 1); num7++)
                {
                    Console.Write(line7[num7]);
                }
                Console.WriteLine(line7[line7.Count - 1]);
            }
            catch
            {
                Console.WriteLine("Could you please repeat that?");
            }
        }

        private void dispScoreSave(int fileNumber)
        {
            for (int i = 0; i < saveList.Count; i++)
            {
                switch (saveList[i])
                {
                    case "d0":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "e0":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "f0":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "g0":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "a":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "b":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "c":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "d":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "e":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "f":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "g":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "a2":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "b2":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "c2":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;

                    case "##":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i + 1] + Environment.NewLine);
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i + 2] + Environment.NewLine);
                        break;

                    case "||":
                        File.AppendAllText(@"C:\\Users\\" + Environment.UserName + @"\Desktop\Composer3_" + Convert.ToString(fileNumber) + ".co3", saveList[i] + Environment.NewLine);
                        break;
                }
            }
        }

        private void initProgram()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.WriteLine("Welcome to Composer 3 \n For help at any time within the program press 'h'. \nTo play your composition at any time press 'p'.");
            Console.Title = "Composer 3";
        }

        private static void Main(string[] args)
        {
            int back = 1;
            music.initProgram();
            Console.WriteLine();
            music.startDisplay();
            while (true)
            {
                try
                {
                    noteValue = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
                switch (noteValue)
                {
                    case "0d":
                        music.disp0D();
                        break;

                    case "0e":
                        music.disp0E();
                        break;

                    case "0f":
                        music.disp0F();
                        break;

                    case "0g":
                        music.disp0G();
                        break;

                    case "1a":
                        music.dispA();
                        break;

                    case "1b":
                        music.dispB();
                        break;

                    case "1c":
                        music.dispC();
                        break;

                    case "1d":
                        music.dispD();
                        break;

                    case "1e":
                        music.dispE();
                        break;

                    case "1f":
                        music.dispF();
                        break;

                    case "1g":
                        music.dispG();
                        break;

                    case "2a":
                        music.disp2A();
                        break;

                    case "2b":
                        music.disp2B();
                        break;

                    case "2c":
                        music.disp2C();
                        break;

                    case "l":
                        music.barLine();
                        break;

                    case "z":
                        Console.WriteLine("How far back do you want to delete?");
                        try
                        {
                            back = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Could you please repeat that?");
                        }
                        music.delete(back);
                        break;

                    case "p":
                        music.player();
                        break;

                    case "s":
                        music.save();
                        break;

                    case "o":
                        music.openScoreDisp();
                        break;

                    case "clear":
                        music.clear();
                        break;

                    case "time":
                        music.timeSignature(null, null);
                        break;

                    default:
                        Console.WriteLine("Please Try again");
                        break;
                }
                music.dispScore();
            }
        }

        private void newLine(int move)
        {
            cursLeft = Console.CursorLeft;
            if (cursLeft >= 0xa9)
            {
                cursorPos += move;
                Console.SetCursorPosition(0, cursorPos);
            }
        }

        private void openScoreDisp()
        {
            Console.WriteLine("Please type the exact fillename without '.co3'.\nFor example: Composer3_16 ");
            inFileName = Console.ReadLine();
            string[] strArray = new string[0x400];
            try
            {
                strArray = File.ReadAllLines(@"C:\\Users\\" + Environment.UserName + @"\Desktop\" + inFileName + ".co3");
            }
            catch
            {
                Console.WriteLine("please try again.");
            }
            for (int i = 0; i < strArray.Length; i++)
            {
                switch (strArray[i])
                {
                    case "d0":
                        music.disp0D();
                        break;

                    case "e0":
                        music.disp0E();
                        break;

                    case "f0":
                        music.disp0F();
                        break;

                    case "g0":
                        music.disp0G();
                        break;

                    case "a":
                        music.dispA();
                        break;

                    case "b":
                        music.dispB();
                        break;

                    case "c":
                        music.dispC();
                        break;

                    case "d":
                        music.dispD();
                        break;

                    case "e":
                        music.dispE();
                        break;

                    case "f":
                        music.dispF();
                        break;

                    case "g":
                        music.dispG();
                        break;

                    case "a2":
                        music.disp2A();
                        break;

                    case "b2":
                        music.disp2B();
                        break;

                    case "c2":
                        music.disp2C();
                        break;

                    case "##":
                        music.timeSignature(strArray[i + 1], strArray[i + 2]);
                        break;

                    case "||":
                        music.barLine();
                        break;
                }
            }
        }

        private void player()
        {
            Console.WriteLine("Unfortunately, music must be played twice to acheive proper tuning.");
            d0.Load();
            e0.Load();
            f0.Load();
            g0.Load();
            a.Load();
            b.Load();
            c.Load();
            d.Load();
            e.Load();
            f.Load();
            g.Load();
            a2.Load();
            b2.Load();
            c2.Load();
            for (int i = 0; i < play.Count; i++)
            {
                switch (play[i])
                {
                    case "d0":
                        d0.Play();
                        Thread.Sleep(0x3e7);
                        d0.Stop();
                        break;

                    case "e0":
                        e0.Play();
                        Thread.Sleep(0x3e7);
                        e0.Stop();
                        break;

                    case "f0":
                        f0.Play();
                        Thread.Sleep(0x3e7);
                        f0.Stop();
                        break;

                    case "g0":
                        g0.Play();
                        Thread.Sleep(0x3e7);
                        g0.Stop();
                        break;

                    case "a":
                        a.Play();
                        Thread.Sleep(0x3e7);
                        a.Stop();
                        break;

                    case "b":
                        b.Play();
                        Thread.Sleep(0x3e7);
                        b.Stop();
                        break;

                    case "c":
                        c.Play();
                        Thread.Sleep(0x3e7);
                        c.Stop();
                        break;

                    case "d":
                        d.Play();
                        Thread.Sleep(0x3e7);
                        d.Stop();
                        break;

                    case "e":
                        e.Play();
                        Thread.Sleep(0x3e7);
                        e.Stop();
                        break;

                    case "f":
                        f.Play();
                        Thread.Sleep(0x3e7);
                        f.Stop();
                        break;

                    case "g":
                        g.Play();
                        Thread.Sleep(0x3e7);
                        g.Stop();
                        break;

                    case "a2":
                        a2.Play();
                        Thread.Sleep(0x3e7);
                        a2.Stop();
                        break;

                    case "b2":
                        b2.Play();
                        Thread.Sleep(0x3e7);
                        b2.Stop();
                        break;

                    case "c2":
                        c2.Play();
                        Thread.Sleep(0x3e7);
                        c2.Stop();
                        break;
                }
            }
        }

        private void save()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("Documents are saved on the desktop");
            Console.WriteLine("Please wait one second");
            fileName = Convert.ToInt32(File.ReadAllText(@"D:\School\IT\Programming\Music creator\Music creator\access.txt"));
            File.WriteAllText(@"D:\School\IT\Programming\Music creator\Music creator\access.txt", Convert.ToString((int) (fileName + 1)));
            Console.WriteLine("Done");
            music.dispScoreSave(fileName);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }

        private void startDisplay()
        {
            Console.WriteLine("Type the note name (in lowercase) and it will appear. \n To delete the last note input,press 'z'. To save your score press 's'. To open a score press 'o'. To clear your score, type 'clear'.\nTo input a time signature type 'time'. To input a barline type 'l'.\n Composer 3 can only accept note values between 0D and 2C. eg. type 1c or 2a or 0f");
        }

        private void timeSignature(string numerator, string denominator)
        {
            if (numerator == null)
            {
                Console.WriteLine("What is the numerator?");
                numerator = Console.ReadLine();
                Console.WriteLine("What is the denominator?");
                denominator = Console.ReadLine();
            }
            line1.Add(" ");
            line2.Add(" ");
            line3.Add(numerator);
            line4.Add(denominator);
            line5.Add(" ");
            line6.Add(" ");
            line7.Add(" ");
            saveList.Add("##");
            saveList.Add(numerator);
            saveList.Add(denominator);
        }
    }
}

