﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Login.Models
{
    public class message
    {
        public int messageID { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string main { get; set; }
        public int replyID { get; set; }
        public string hashtagID { get; set; }
        public byte[] photo { get; set; }
        public int heart { get; set; }
        public int dislike { get; set; }
        public string wholike { get; set; }
        public string whohate { get; set; }
        public DateTime initDate { get; set; }
    }
}