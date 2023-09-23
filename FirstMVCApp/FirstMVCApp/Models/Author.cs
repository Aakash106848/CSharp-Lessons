using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Author
    {
        public int Authorid { set; get; }
        public string Name { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int NoOfBooks {  set; get; }
        public string Royality { set; get; }
    }
}
