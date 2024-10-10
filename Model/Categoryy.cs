using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace daVasstTrees.Model
{
    public class Categoryy
    {
        private int id;
        private string code;
        private string name;

        public Categoryy(int id, string code, string name)
        {
            this.id = id;
            this.code = code;
            this.name = name;
        }
        public Categoryy()
        {
            
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}