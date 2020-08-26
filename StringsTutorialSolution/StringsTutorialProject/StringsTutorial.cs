using System;
using System.Collections.Generic;
using System.Text;

namespace StringsTutorialProject {
    class StringsTutorial {

        public string Firstname;
        public string Lastname;

        public StringsTutorial() {
            Firstname = "Kenneth";
            Lastname = "Doud";
        }
        public StringsTutorial(string firstname, string lastname) {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Fullname() {

            //var Firstname = "Gregory";
            //var Lastname = "Doud";

            //var fullname = Firstname + " " + Lastname;
            var fullname = $"{Lastname}, {Firstname}";
            return fullname;
        }

        public string Fullname2() {

            //var Firstname = "Gregory";
            //var Lastname = "Doud";

            var fullname = $"{Firstname} {Lastname}";
            return fullname;

        }
    }
}
