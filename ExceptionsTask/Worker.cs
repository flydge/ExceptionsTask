using System;


namespace ExceptionsTask
{
    public class Worker
    {
        private string _name;
        private int _age;

        public Worker(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public override string ToString()
        {
            return String.Format("name:{0,-20} age:{1,3}",_name,_age);
        }
    }
}