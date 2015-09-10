using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TagMakerTester
    {
        private TagMaker Tag;

        public TagMakerTester() 
        {
            Tag = new TagMaker("Vlad T", "BCC");
        }

        public void RunTests()
        {
            Console.WriteLine("Testing TagMaker");

            //Console.WriteLine("Setters work...");
            //Me.FirstName = "Mr. " + Me.GetFirstName();
            //Me.LastName = "T";
            //Console.WriteLine(Me);

            Console.WriteLine("Here goes a blank tag");
            Tag.PrintBlank();

            Console.WriteLine("One ticket for Vlad T from BCC");
            Tag.Print();

            Console.WriteLine("Vlad T just got himself a job at FBI");
            Tag.Name = "Agent Vlad T";
            Tag.Organization = "FBI";
            Tag.Print();

            Console.WriteLine("Here goes Vlad T's tag for the broad audience");
            Tag.PrintBlank();

            Console.WriteLine("Vlad T gets fired :(");
            Tag.ClearOrganization();
            Tag.Print();

            Console.WriteLine("And goes in hiding...");
            Tag.ClearName();
            Tag.Print();

            Console.WriteLine("Done testing the TagMaker class!");
        }
    }
}


/*

Testing TagMaker
Here goes a blank tag
##############################################################################
###                           ANNUAL CONFERENCE                            ###
##############################################################################
### NAME:                                                                  ###
###                                                                        ###
##############################################################################
### ORGANIZATION:                                                          ###
###                                                                        ###
##############################################################################

One ticket for Vlad T from BCC
##############################################################################
###                           ANNUAL CONFERENCE                            ###
##############################################################################
### NAME: Vlad T                                                           ###
###                                                                        ###
##############################################################################
### ORGANIZATION: BCC                                                      ###
###                                                                        ###
##############################################################################

Vlad T just got himself a job at FBI
##############################################################################
###                           ANNUAL CONFERENCE                            ###
##############################################################################
### NAME: Agent Vlad T                                                     ###
###                                                                        ###
##############################################################################
### ORGANIZATION: FBI                                                      ###
###                                                                        ###
##############################################################################

Here goes Vlad T's tag for the broad audience
##############################################################################
###                           ANNUAL CONFERENCE                            ###
##############################################################################
### NAME:                                                                  ###
###                                                                        ###
##############################################################################
### ORGANIZATION:                                                          ###
###                                                                        ###
##############################################################################

Vlad T gets fired :(
##############################################################################
###                           ANNUAL CONFERENCE                            ###
##############################################################################
### NAME: Agent Vlad T                                                     ###
###                                                                        ###
##############################################################################
### ORGANIZATION:                                                          ###
###                                                                        ###
##############################################################################

And goes in hiding...
##############################################################################
###                           ANNUAL CONFERENCE                            ###
##############################################################################
### NAME:                                                                  ###
###                                                                        ###
##############################################################################
### ORGANIZATION:                                                          ###
###                                                                        ###
##############################################################################

Done testing the TagMaker class!

*/