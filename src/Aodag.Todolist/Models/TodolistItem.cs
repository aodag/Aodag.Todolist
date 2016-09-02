using System;

namespace Aodag.Todolist.Models
{
    public class TodolistItem
    {
        public string Name
        {
            get;
            set;
        }

        public bool Finished
        {
            get;
            set;
        }

        public void Finish()
        {
            Finished = true;
        }
    }
}