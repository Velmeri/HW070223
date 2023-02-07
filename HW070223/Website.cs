using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW070223
{
    internal class Website
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string IP { get; set; }
        public Website() { }
        public Website(string name, string path, string description, string ip)
        {
            Name = name;
            Path = path;
            Description = description;
            IP = ip;
        }
    }
}
