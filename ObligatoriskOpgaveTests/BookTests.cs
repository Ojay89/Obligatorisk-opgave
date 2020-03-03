using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace BookTest
{
    [TestClass()]
    public class BookTests
    {
        private Book _book;

        [TestInitialize]
        public void BookTest()
        {
            _book = new Book(Title: "Omars bog", Author: "Omar Jaber", 498, "1942432421123"); //arrange
        }

        [TestMethod()]
        public void TitleTest()
        {
            _book.Title = "Omars bog"; //act
            Assert.AreEqual("Omars bog", _book.Title); // Assert
        }

        [TestMethod()]
        public void AuthorTest()
        {
            _book.Author = "Omar Jaber"; //act
            Assert.AreEqual("Omar Jaber", _book.Author); //Assert
        }

        [TestMethod()]
        public void PageNoTest()
        {
            _book.PageNo = 498; //act
            Assert.AreEqual(498, _book.PageNo); //Assert
        }

        [TestMethod()]
        public void Isbn13Test()
        {
            _book.Isbn13 = "1942432421123"; //act
            Assert.AreEqual("1942432421123", _book.Isbn13); //Assert
        }


    }
}

namespace ObligatoriskOpgaveTests
{
    class BookTests
    {
    }
}
