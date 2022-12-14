using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Chu_FinalQ6
{
    public class LoggingClass
    {
        public LoggingClass() { }
        private static LoggingClass instance = new LoggingClass();
        public static LoggingClass GetInstance() { return instance; }
        public Settings OpenLogFile(string logFileName = "c:\\templates\\player.json")
        {
            StreamReader reader = new StreamReader(logFileName);
            string info = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<Settings>(info);
        }
        public void WriteToLog(Settings setting, string logInfo = "c:\\templates\\player.json")
        {
            string info = JsonConvert.SerializeObject(setting);
            StreamWriter writer = new StreamWriter(logInfo);
            writer.Write(info);
            writer.Close();
        }
    }
    public class Settings
    {
        public string player_name;
        public int level;
        public int hp;
        public string[] inventory;
        public string license_key;
        public Settings()
        {
            this.player_name = "dschuh";
            this.level = 4;
            this.hp = 99;
            this.inventory = new string[]{"spear", "water bottle", "hammer", "sonic screwdriver", "cannonball", "wood", "Scooby snack", "Hydra", "poisonous potato", "dead bush", "repair powder"};
            this.license_key = "DFGU00-1454";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings user = new Settings();
            LoggingClass singleton = LoggingClass.GetInstance();
            singleton.WriteToLog(user);
            Settings load = singleton.OpenLogFile();
            Console.WriteLine("Name:" + load.player_name + " Lvl:" + load.level);
        }
    }
}