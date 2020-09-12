using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface LibraryVisitor
    {
        void Quiet();
        void Professional();
        void Matured();
    }

    public interface OfficeWorker
    {
        void Friendly();
        void Professional();
        void Matured();
    }

    public interface Friend
    {
        void Anger();
        void Friendly();
        void Matured();
    }
    public class Person : LibraryVisitor, OfficeWorker, Friend
    {
        public void Quiet() { }
        public void Anger() { }
        public void Friendly() { }
        public void Professional() { }
        public void Matured() { }
    }
    public class Library
    {

        public void Visit(LibraryVisitor obj)
        {
            //obj.Anger();//Error
            //obj.Friendly();//Error
            obj.Quiet();
            obj.Matured();
            obj.Professional();
        }

    }

    public class Office
    {
        public void Work(OfficeWorker obj)
        {
            //obj.Anger();//Error
            obj.Friendly();
            //obj.Quiet();//Error
            obj.Matured();
            obj.Professional();
        }
    }

    public class FriendCircle
    {
        public void Hangout(Friend obj)
        {
            obj.Anger();
            obj.Friendly();
            //obj.Quiet();//Error
            obj.Matured();
            //obj.Professional();//Error
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person();

            Library _lib = new Library();
            _lib.Visit(personObj);

            Office _office = new Office();
            _office.Work(personObj);

            FriendCircle _meetup = new FriendCircle();
            _meetup.Hangout(personObj);



        }

    }
}
