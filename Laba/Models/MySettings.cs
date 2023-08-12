using System;
using Laba.Themes;
using Laba.Views;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laba.Models
{
    public class MySettings
    {
        static public bool CurrentTheme { get; set; }
        static public bool CurrentLanguage { get; set; }
        static public int CurrentImage { get; set; }
        static public int CurrentSortType { get; set; }

        static public string my_input = "";
        static public int my_contry = 7;
        static public bool my_favorite = false;

        static public void ChangeTheme()
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            mergedDictionaries.Clear();
            if (MySettings.CurrentTheme)
            {
                mergedDictionaries.Add(new LightTheme());
            }
            else mergedDictionaries.Add(new DarkTheme());
        }

    }

    public class WorkWithFile
    {

        static public void ChangeSettings(string temp)
        {
            int temp_int = Convert.ToInt32(temp);
            int first = temp_int / 10;
            int second = temp_int % 10;
            if (first == 1)
            {
                MySettings.CurrentLanguage = true;
            }
            else
            {
                MySettings.CurrentLanguage = false;
            }
            if (second == 1)
            {
                MySettings.CurrentTheme = true;
            }
            else
            {
                MySettings.CurrentTheme = false;
            }
        }
        static public string PrepareToSave()
        {
            string opa = string.Empty;
            if (MySettings.CurrentLanguage)
            {
                opa += '1';
            }
            else
            {
                opa += '2';
            }
            if (MySettings.CurrentTheme)
            {
                opa += '1';
            }
            else
            {
                opa += '2';
            }
            return opa;
        }

        static public bool IsExist()
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "TextFile1.txt");
            if (backingFile == null || !File.Exists(backingFile))
            {
                return false;
            }
            return true;
        }

        static public string ReadData()
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "TextFile1.txt");
            string FileData = string.Empty;
            using (var reader = new StreamReader(backingFile, true))
            {
                FileData = reader.ReadLine();
            }
            return FileData;
        }
        static public async Task SaveData(string Data)
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "TextFile1.txt");
            using (var writer = File.CreateText(backingFile))
            {
                await writer.WriteLineAsync(Data);
            }
        }
    }
}
