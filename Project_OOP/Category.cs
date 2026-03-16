using System;

namespace Project_OOP
{
    public class Category
    {
        private int _id;
        private string _name;

        public int Id { get; set; }
        public string Name { get; set; }

        public Category()
        {
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}