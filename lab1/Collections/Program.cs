using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp1
{
    //Element
    public class Film
    {
        public Film()
        {
            this.Name = "Empty";
            this.Time = 0;
        }
        public Film(string _name, int _time)
        {
            this.Name = _name;
            this.Time = _time;
        }
        public string Name { get; set; }
        public int Time { get; set; }
    }
    //Перечисляемый класс
    public class Cinema : IEnumerable<Film>
    {
        private Film[] _items = new Film[0];
        public int ItemsCount
        {
            get { return _items.Length; }
        }
        public void AddItem(string _name, int _time)
        {
            Array.Resize(ref _items, ItemsCount + 1);
            Film _newitem = new Film(_name, _time);
            _items[ItemsCount - 1] = _newitem;
        }
        public Film GetItem(int _index)
        {
            return _items[_index];
        }
        public void DeleteItem(int _index)
        {
            if (_index != ItemsCount)
            {
                Film _testFilm = new Film();
                _testFilm = _items[ItemsCount - 1];
                _items[_index] = _testFilm;
            }
            Array.Resize(ref _items, ItemsCount - 1);
        }
        //Класс Перечислитель
        private class cinemaEnumerator : IEnumerator<Film>
        {
            private readonly Film[] _data; //локальная копия данных
            private int _position = -1; //текущая позиция в наборе
            public cinemaEnumerator(Film[] values)
            {
                _data = new Film[values.Length];
                Array.Copy(values, _data, values.Length);
            }
            //Текущий объект набора
            public object Current { get { return _data[_position]; } }
            Film IEnumerator<Film>.Current { get { return _data[_position]; } }
            public void Dispose()
            {
                //Пустая реализация
            }
            public bool MoveNext()
            {
                if (_position < _data.Length - 1)
                {
                    _position++;
                    return true;
                }
                return false;
            }
            public void Reset() { _position = -1; }
        }

        public IEnumerator<Film> GetEnumerator()
        {
            return new cinemaEnumerator(_items);
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    //Main Program
    class Program
    {
        static void Main(string[] args)
        {
            //Тестовые объекты
            Cinema testcinema = new Cinema();
            Film testfilm = new Film();
            //AddItem и Foreach (Перечислитель)
            Console.WriteLine("Add elements and count them :");
            testcinema.AddItem("Action", 1);
            testcinema.AddItem("Serials", 2);
            testcinema.AddItem("Comics", 3);
            testcinema.AddItem("Thriller", 4);
            testcinema.AddItem("Drama", 5);
            foreach (Film _book in testcinema)
            {
                Console.WriteLine(_book.Time + ") " + _book.Name);
            }
            //GetItem
            Console.WriteLine("\nGet element (GetItem) : ");
            int i = Convert.ToInt32(Console.ReadLine());
            testfilm = testcinema.GetItem(i - 1);
            Console.WriteLine(testfilm.Name + '(' + testfilm.Time + ')');
            //ItemsCount
            i = testcinema.ItemsCount;
            Console.WriteLine("\nCount of elements (ItemsCount) : " + i);
            //DeleteItem
            Console.WriteLine("\nDelete element (DeleteItem) : ");
            i = Convert.ToInt32(Console.ReadLine());
            testcinema.DeleteItem(i - 1);
            foreach (Film _book in testcinema)
            {
                Console.WriteLine(_book.Name);
            }
        }
    };
}
