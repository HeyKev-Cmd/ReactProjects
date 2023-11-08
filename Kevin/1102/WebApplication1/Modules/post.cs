using System.Text.Json.Serialization;

namespace WebApplication1.Modules
{
    public class post
    {
        public  long like_count { set; get; }
        public DateTime post_date { set; get; }
        public string content { set; get; }
        
        public string author { set; get; }
        public post()
        {
            like_count = 0;
            post_date= DateTime.Now;
        }

    }
}
