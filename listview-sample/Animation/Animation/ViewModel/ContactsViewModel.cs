using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Animation
{
    public class ContactsViewModel
    {
        #region Public Properties

        public ObservableCollection<Contacts> CustomerDetails
        {
            get;
            set;
        }
        public Command<object> OnTap { get; }
        #endregion

        #region Fields

        private Random random = new Random();

        #endregion

        #region Ctor

        public ContactsViewModel()
        {
            this.GetContactDetails(20);
            OnTap = new Command<object>(OnTapped);
        }

        #endregion

        #region Get Contacts Details

        private void GetContactDetails(int count)
        {
            CustomerDetails = new ObservableCollection<Contacts>();

            for (int i = 0; i < CustomerNames.Length-1; i++)
            {
                var details = new Contacts()
                {
                    ContactType = contactType[random.Next(0, 4)],
                    ContactNumber = random.Next(100, 400).ToString() + "-" + random.Next(500, 800).ToString() + "-" + random.Next(1000, 2000).ToString(),
                    ContactName = CustomerNames[i],
                };
                CustomerDetails.Add(details);
            }
        }
        private async void OnTapped(object obj)
        {
            var itemTemplateGrid = obj as Grid;
            var item = itemTemplateGrid.BindingContext as Contacts;

            itemTemplateGrid.Opacity = 0;
            await itemTemplateGrid.FadeTo(1, 1000, Easing.SinInOut);

            this.CustomerDetails.Remove(item);
        }

        #endregion

        #region Customer Information

        string[] contactType = new string[]
        {
            "HOME",
            "WORK",
            "MOBILE",
            "OTHER",
        };

        string[] CustomerNames = new string[] {
           "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson",
            "Mason",
            "Liam",
            "Jacob",
            "Jayden",
            "Ethan",
            "Noah",
            "Lucas",
            "Logan"    ,
            "Caleb"    ,
            "Caden"    ,
            "Jack"    ,
            "Ryan"    ,
            "Connor"    ,
            "Michael"    ,
            "Elijah"    ,
            "Brayden"    ,
            "Benjamin"   ,
            "Nicholas"   ,
            "Alexander"  ,
            "William"    ,
            "Matthew"    ,
            "James"    ,
            "Lando"    ,
            "Nathan"    ,
            "Dylan"    ,
            "Evan"    ,
            "Luke"    ,
            "Andrew"    ,
            "Gabriel"    ,
            "Gavin"    ,
            "Joshua"    ,
            "Owen"    ,
            "Daniel"    ,
            "Carter"    ,
            "Tyler"    ,
            "Cameron"    ,
            "Christian"  ,
            "Wyatt"    ,
            "Henry"    ,
            "Eli"    ,
            "Joseph"    ,
            "Max"    ,
            "Isaac"    ,
            "Samuel"    ,
            "Anthony"    ,
            "Grayson"    ,
            "Zachary"    ,
            "David"    ,
            "Christopher",
            "John"    ,
            "Isaiah"    ,
            "Levi"    ,
            "Jonathan"   ,
            "Oliver"    ,
            "Chase"    ,
            "Cooper"    ,
            "Tristan"    ,
            "Colton"    ,
            "Austin"    ,
            "Colin"    ,
            "Charlie"    ,
            "Dominic"    ,
            "Parker"    ,
            "Hunter"    ,
            "Thomas"    ,
            "Alex"    ,
            "Ian"    ,
            "Jordan"    ,
            "Cole"    ,
            "Julian"    ,
            "Aaron"    ,
            "Carson"    ,
            "Miles"    ,
            "Blake"    ,
            "Brody"    ,
            "Adam"    ,
            "Sebastian"  ,
            "Adrian"    ,
            "Nolan"    ,
            "Sean"    ,
            "Riley"    ,
            "Bentley"    ,
            "Xavier"    ,
            "Hayden"    ,
            "Jeremiah"   ,
            "Jason"    ,
            "Jake"    ,
            "Asher"    ,
            "Micah"    ,
            "Jace"    ,
            "Brandon"    ,
            "Josiah"    ,
            "Hudson"    ,
            "Nathaniel"  ,
            "Bryson"    ,
            "Ryder"    ,
            "Justin"    ,
            "Bryce"    ,
        };

        #endregion

    }
}
