using System;


namespace Kumustagram_API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int User { get; set; }
        public string CommentStr { get; set; }

        public int ContentId { get; set; } // foreign key

        public Content Content { get; set; } // reference to Content

    }
}
