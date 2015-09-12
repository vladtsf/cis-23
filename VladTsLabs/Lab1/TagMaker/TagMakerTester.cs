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

            try
            {
                Tag.Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent aliquam hendrerit neque sit amet tristique. Nullam rhoncus vulputate est, id ullamcorper sem interdum a. Aenean libero lorem, convallis a velit in, faucibus eleifend erat. Praesent hendrerit fringilla nulla, id ultricies odio faucibus eu. Donec ultricies vitae nibh eget lobortis. Donec nec pharetra leo. Maecenas vel maximus lorem. Sed a diam tortor. Morbi gravida vestibulum risus, ac accumsan elit sagittis vitae. Nunc id convallis risus. Proin a dolor odio. Cras dictum dui leo, non varius metus mollis sit amet. In eu lorem tincidunt, vestibulum enim vel, tincidunt enim. Nulla ultrices ipsum porta, hendrerit felis a, laoreet massa. Mauris vulputate scelerisque tortor, sed dictum leo sagittis vitae. Aliquam non mi sed magna ornare hendrerit in accumsan tortor.";
            }
            catch (Exception e)
            {
                Console.WriteLine("If the name doesn't fit the line, it will say \"{0}\"", e.Message);
            }

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

If the name doesn't fit the line, it will say "The value "Lorem ipsum dolor sit
amet, consectetur adipiscing elit. Praesent aliquam hendrerit neque sit amet tri
stique. Nullam rhoncus vulputate est, id ullamcorper sem interdum a. Aenean libe
ro lorem, convallis a velit in, faucibus eleifend erat. Praesent hendrerit fring
illa nulla, id ultricies odio faucibus eu. Donec ultricies vitae nibh eget lobor
tis. Donec nec pharetra leo. Maecenas vel maximus lorem. Sed a diam tortor. Morb
i gravida vestibulum risus, ac accumsan elit sagittis vitae. Nunc id convallis r
isus. Proin a dolor odio. Cras dictum dui leo, non varius metus mollis sit amet.
 In eu lorem tincidunt, vestibulum enim vel, tincidunt enim. Nulla ultrices ipsu
m porta, hendrerit felis a, laoreet massa. Mauris vulputate scelerisque tortor,
sed dictum leo sagittis vitae. Aliquam non mi sed magna ornare hendrerit in accu
msan tortor." won't fit the line"
Done testing the TagMaker class!

*/