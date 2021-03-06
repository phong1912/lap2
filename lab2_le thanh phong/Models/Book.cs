﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2_le_thanh_phong.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;
        public Book()
        {

        }
        public Book(int id,string title,string author,string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }

        }
        public string Image_cover
        {
            get { return image_cover; }
            set { image_cover = value; }
        }
    }
}