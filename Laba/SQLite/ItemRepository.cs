using Laba.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Laba.SQLite
{
    public class ItemRepository
    {
        SQLiteConnection database;

        public ItemRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<MyItem>();
        }

        public MyItem GetItem(int id)
        {
            return database.Get<MyItem>(id);
        }

        public IEnumerable<MyItem> GetSortItems()
        {
            return (from i in database.Table<MyItem>() orderby i.Title select i).ToList();
        }

        public int DeleteItem(int id)
        {
            return database.Delete<MyItem>(id);
        }

        public int SaveItem(MyItem item)
        {
            if (item.id != 0)
            {
                database.Update(item);
                return item.id;
            }
            else
            {
                return database.Insert(item);
            }
        }


        public bool CheckNull(int id)
        {
            bool result = true;
            try
            {
                database.Get<MyItem>(id);
            }
            catch
            {
                result = false;
            }
            finally
            {

            }
            return result;

        }

        public IEnumerable<MyItem> GetItems()
        {
            return (from i in database.Table<MyItem>() select i).ToList();
        }

       /* public IEnumerable<MyItem> GetItems(int kingdom)
        {
            return (from i in database.Table<MyItem>() where i.Kingdom == kingdom orderby i.Title select i).ToList();
        }*/
        public IEnumerable<MyItem> GetSortItems1()
        {

            var templist = GetSortItems();

            if (MySettings.my_favorite)
            {
                templist = (from i in templist where i.IsFavorite == true select i).ToList();
            }

            if (MySettings.my_contry != 7)
            {
                templist = (from i in templist where i.Country == MySettings.my_contry orderby i.Title select i).ToList();
            }

            if (MySettings.my_input != null)
            {
                templist = (from i in templist
                            where i.Title.ToUpper().Contains(MySettings.my_input.ToUpper())
                            select i).ToList();
            }


            return templist;
        }
    }
        
}
