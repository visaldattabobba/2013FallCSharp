using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Input;
using System.Threading;

namespace BasicContacts
{
    public class ContactsVM: BaseVM
    {
        CSharpContext _DB;
        public ContactsVM()
        {
            int i = 0;
            _DB = new CSharpContext();
            Contacts = new ObservableCollection<Contact>();
            SaveCommand = new DelegateCommand(() => _DB.SaveChanges());
            AddCommand = new DelegateCommand(() =>
            {
                CurrentContact = new Contact();
                Contacts.Add(CurrentContact);
                _DB.Contacts.Add(CurrentContact);
            });
            AddEmailCommand = new DelegateCommand(() =>
            {
                var cm = new ContactMethod();
                CurrentContact.ContactMethods.Add(cm);
            });
            DeleteCommand = new DelegateCommand(() =>
            {
                _DB.Contacts.Remove(CurrentContact);
                Contacts.Remove(CurrentContact);
            });

            Init();
        }

        async void Init()
        {
            IsLoading = System.Windows.Visibility.Visible;
            var temp = from x in _DB.Contacts
                       from y in _DB.Contacts
                       select x;
            var contacts = await temp.Take(100000).ToListAsync();
            foreach (var item in contacts)
            {
                Contacts.Add(item);
            }
            IsLoading = System.Windows.Visibility.Hidden;

        }

        public ObservableCollection<Contact> Contacts { get; private set; }
        public ICommand SaveCommand { get; private set; }
        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand AddEmailCommand { get; private set; }

        private Contact _CurrentContact;

        public Contact CurrentContact
        {
            get { return _CurrentContact; }
            set { _CurrentContact = value; OnPropertyChanged(); }
        }

        private System.Windows.Visibility _IsLoading;
        public System.Windows.Visibility IsLoading
        {
            get { return _IsLoading; }
            set { _IsLoading = value; OnPropertyChanged(); }
        }
        

        
    }
}
