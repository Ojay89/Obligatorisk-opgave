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
            _book = new Book(Title: "Omars bog", Author: "Omar Jaber", 498, "1942432421123"); //arrange /act
        }

        [TestMethod()]
        public void TitleTest()
        {
            /*_book.Title = "Omars bog";*/ //act
            Assert.AreEqual("Omars bog", _book.Title); // Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void TitleTestNullReference()
        {
            _book.Title = null; //act
            //Assert.AreEqual(null, _book.Title); // Assert
        }

        [TestMethod()]
        public void AuthorTest()
        {
            /*_book.Author = "Omar Jaber";*/ //act
            Assert.AreEqual("Omar Jaber", _book.Author); //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void AuthorTestNullReference()
        {
            _book.Author = null; //act
            //Assert.AreEqual("Omar Jaber", _book.Author); //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AuthorTestUnder2Length()
        {
            _book.Author = "O"; //act
            Assert.AreEqual("O", _book.Author); //Assert
        }


        [TestMethod()]
        public void PageNoTest()
        {
            //_book.PageNo = 498; //act
            Assert.AreEqual(498, _book.PageNo); //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PageNoTestLessThan4()
        {
            _book.PageNo = 3; //act
            Assert.AreEqual(3, _book.PageNo); //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PageNoTestMoreThan1000()
        {
            _book.PageNo = 1021; //act
            Assert.AreEqual(1021, _book.PageNo); //Assert
        }

        [TestMethod()]
        public void Isbn13Test()
        {
            /*_book.Isbn13 = "1942432421123";*/ //act
            Assert.AreEqual("1942432421123", _book.Isbn13); //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Isbn13TestLessThan13Digits()
        {
            _book.Isbn13 = "9421123"; //act
            Assert.AreEqual("9421123", _book.Isbn13); //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Isbn13TestMorethan13Digits()
        {
            _book.Isbn13 = "111942432421123"; //act
            Assert.AreEqual("111942432421123", _book.Isbn13); //Assert
        }



    }
}
