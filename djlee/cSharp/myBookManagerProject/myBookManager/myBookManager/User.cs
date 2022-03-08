using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBookManager
{
    public class User
    {
        public int Id { get; set; } //DB부분은 PK가 될 듯 하다.
        public string Name { get; set; }
    }
}
