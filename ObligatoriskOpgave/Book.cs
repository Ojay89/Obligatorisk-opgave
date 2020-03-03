using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace ObligatoriskOpgave
{
    public class Book
    {
        //Instance Field
        private string _title;
        private string _author;
        private int _pageNo;
        private string _isbn13;

        //Constructor
        public Book(string Title, string Author, int PageNo, string Isbn13)
        {
            _title = Title;
            _author = Author;
            _pageNo = PageNo;
            _isbn13 = Isbn13;
        }

        //Properties
        public string Title
        {
            get => _title;
            set { _title = value; }
        }

        public string Author
        {
            get => _author;
            set
            {
                if (value == null) throw new ArgumentException("Skriv et navn");
                if (value.Length < 2) throw new ArgumentException("Forfatter navn skal være minimum 2 tegn langt");
                _title = value;
            }

        }

        public int PageNo
        {
            get => _pageNo;
            set
            {
                if (value <= 4) throw new ArgumentException("Bogen er for kort");
                if (value >= 1000) throw new ArgumentException("Bogen er for lang");
            }
        }

        public string Isbn13
        {
            get => _isbn13;

            set

            {
                _isbn13 = value;
                if (value.Length == 13) _isbn13 = value;
                else if (value.Length != 13) throw new ArgumentOutOfRangeException("ISBN er for lang. Skal være 13 cifre");
                
            }
        }
    }
}
