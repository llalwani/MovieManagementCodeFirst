﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieManagementCodeFirst.Models
{
    public class Film
    {
        public int ID { get; set; }
        public int FilmTypeID { get; set; }
        [Required(ErrorMessage = "Hãy nhập tên phim")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Hãy nhập giá cho phim")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Hãy chọn ảnh cho phim")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Hãy nhập tên đạo diễn phim")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Hãy nhập mô tả cho phim")]
        public string Description { get; set; }
        public virtual FilmType FilmType { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public Film()
        {

        }
    }
}