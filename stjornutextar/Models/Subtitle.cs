using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace stjornutextar.Models
{
    public class Subtitle
    {
        public int GetSubtitles { get; set; }
        public int CreateSubtitle { get; set; }
        public int DislikeSubtitle { get; set; }
        public int GetSubPartLikes { get; set; }
        public int LikeSubPart { get; set; }
        public int DislikeSubPart { get; set; }
    }
}