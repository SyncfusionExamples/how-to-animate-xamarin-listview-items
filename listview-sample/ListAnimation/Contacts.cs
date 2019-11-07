using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ListAnimation
{
    public class Contacts : INotifyPropertyChanged
    {
        #region Fields

        private string contactName;
        private string contactNo;
        private string contactType;

        #endregion

        #region Constructor

        public Contacts()
        {

        }

        #endregion

        #region Public Properties

        public string ContactName
        {
            get { return this.contactName; }
            set
            {
                this.contactName = value;
                RaisePropertyChanged("ContactName");
            }
        }

        public string ContactNumber
        {
            get { return contactNo; }
            set
            {
                this.contactNo = value;
                RaisePropertyChanged("ContactNumber");
            }
        }

        public string ContactType
        {
            get { return contactType; }
            set
            {
                this.contactType = value;
                RaisePropertyChanged("ContactType");
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
