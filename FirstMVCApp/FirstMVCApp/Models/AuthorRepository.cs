using Microsoft.AspNetCore.Authorization.Policy;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FirstMVCApp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            string fname = @"C:\temp\file.txt";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            //list = null;
            bool isFileExists = System.IO.File.Exists(fname);
            if (isFileExists) 
            {
                using (StreamReader sr = new StreamReader(fname)) 
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    string[] data = strAuthor.Split(',');
                    Author author = null;
                    if(data.Length==5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.Authorid,author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data =strAuthor.Split(",");
                            if (data.Length == 5) 
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.Authorid, author);
                            }
                        }
                    }
                }
            }
            return list;
        }
        public static Author StringToAuthor(string[] data,Author author)
        {
            author.Authorid = int.Parse(data[0]);
            author.Name = data[1];
            author.DateOfBirth = DateTime.Parse(data[2]);
            author.NoOfBooks= int.Parse(data[3]);
            author.Royality = data[4];

            return author;
        }
        //public static List<Author>GetAuthorList()
        //{

        //}
        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list!=null)
            {
                author = list.FirstOrDefault(x=>(x.Key==id)).Value;
            }
            return author;
        }
        public static void SaveToFile(Author pAuthor) 
        {
            string fName = @"C:\temp\file.txt";
            string strAuthor = $"{pAuthor.Authorid},{pAuthor.Name},{pAuthor.DateOfBirth},{pAuthor.NoOfBooks},{pAuthor.Royality}{Environment.NewLine}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static void UpdateAuthorToFile(Author pAuthor) 
        {
            string fName = @"c:\temp\file.txt";
            Dictionary<int,Author>list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = string.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach(Author author in list.Values)
                {
                    if (author.Authorid != pAuthor.Authorid)
                    {
                        strAuthor = $"{author.Authorid},{author.Name},{author.DateOfBirth},{author.NoOfBooks},{author.Royality}";
                    }
                    else
                    {
                       strAuthor= $"{pAuthor.Authorid},{pAuthor.Name},{pAuthor.DateOfBirth},{pAuthor.NoOfBooks},{pAuthor.Royality}";
                    }
                    sw.WriteLine(strAuthor);

                }
            }
        }
        //public static void RemoveAuthor(int id) 
        //{
        //    string fName = @"c:\temp\file.txt";
        //    Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
        //    string strAuthor = string.Empty;
        //    using (StreamWriter sw = new StreamWriter(fName,false))
        //    {
        //        foreach (Author author in list.Values) 
        //        {
        //            if (author.Authorid !=  id)
        //            {
        //                strAuthor = $"{author.Authorid},{author.Name},{author.DateOfBirth},{author.NoOfBooks},{author.Royality}";
        //            }
        //            sw.WriteLine(strAuthor);
        //        }
        //    }
        //}
        public static void RemoveAuthor(int id)
        {
            String fName = @"c:\temp\file.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
            foreach (Author author in list.Values)
            {
                if (author.Authorid != id)
                {
                    sbAuthors.Append($"{author.Authorid}, {author.Name}, {author.DateOfBirth}, {author.NoOfBooks}, {author.Royality}");



                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());
        }
        public static void SaveAllAuthorsToFile() 
        {

        }

    }
}
