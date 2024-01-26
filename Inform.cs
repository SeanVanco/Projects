using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Inform
    {
        private static string _profName1 = "Instructor One";
        private static string _profName2 = "Instructor Two";
        private static string _profName3 = "Instructor Three";
        private static string _profName4 = "Instructor Four";
        private static string _accYear1 = "Fall 21";
        private static string _accYear2 = "Spring 22";
        private static string _accYear3 = "Fall 22";
        private static string _accYear4 = "Spring 23";
        private static string choice = "";
        private static string FileName = "";

        public static string filePath
        {
            get { return FileName; }
            set { FileName = value; }
        }
        public static string ProfName1
        {
            get { return _profName1; }
            set { _profName1 = value; }
        }
        public static string ProfName2
        {
            get { return _profName2; }
            set { _profName2 = value; }
        }
        public static string ProfName3
        {
            get { return _profName3; }
            set { _profName3 = value; }
        }
        public static string ProfName4
        {
            get { return _profName4; }
            set { _profName4 = value; }
        }
        public static string AccYear1
        {
            get { return _accYear1; }
            set { _accYear1 = value; }
        }
        public static string AccYear2
        {
            get { return _accYear2; }
            set { _accYear2 = value; }
        }
        public static string AccYear3
        {
            get { return _accYear3; }
            set { _accYear3 = value; }
        }
        public static string AccYear4
        {
            get { return _accYear4; }
            set { _accYear4 = value; }
        }
        public static string Choice
        {
            get { return choice; }
            set { choice = value; }
        }
    }
}
