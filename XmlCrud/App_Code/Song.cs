﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft;
namespace XmlCrud.App_Code
{
    public class Song
    {
        public string id { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public string year { get; set; }

    }
    public class Songs
    {
        public List<Song> songs { get; set; }

    }
}