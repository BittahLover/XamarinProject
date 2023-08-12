using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Laba.Models
{
    [Table("MyItems")]
    public class MyItem
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }
        public int Country { get; set; }
        public string Motto { get; set; }
        public string Producer { get; set; }
        public string Genre { get; set; }
        public string MainRoles { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool IsFavorite { get; set; }
    }
}
