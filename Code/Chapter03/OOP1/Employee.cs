using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        //instance variable 
        public Employee()
        {

        }
        public Employee(int _id,string _name, string _email,string _phone)//local variable
        {
            this._id = _id;//nếu không có this thì cả 2 dêud trỏ tới và ưu tiên cho local trước
                           //dùng this để trỏ this._id tới private int _id và _id tới int _id.
            this._name = _name;
            //hoặc:
            Email = _email;//là gọi setter cho property Email
            Phone = _phone;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        public void PrintInfor()
        {
            Console.WriteLine($"{_id}\t{_name}\t{_email}\t{_phone}");
        }
        public override string ToString()
        {
            string mgs = $"{_id}\t{_name}\t{_email}\t{_phone}";
            return mgs;
        }
    }

}
