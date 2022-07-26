using Chappa.Core;
using Chappa.MVVM.Model;
using System;
using System.Collections.ObjectModel;

namespace Chappa.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /*Commands*/
        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set {
                _selectedContact = value;
                OnPropertyChanged();

            }
        }

        private string _message;

        public string Message
        {
            get { return _message;  }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            
            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });
                Message = "";
            });


            Messages.Add(new MessageModel
            {
                Username = "Nana",
                UsernameColor = "#409aff",
                ImageSource = "https://cdn.icon-icons.com/icons2/2643/PNG/512/male_people_avatar_man_boy_curly_hair_icon_159362.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true,
            });
        
            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Skerry",
                    UsernameColor = "#409aff",
                    ImageSource = "https://cdn.icon-icons.com/icons2/2643/PNG/512/male_people_avatar_man_boy_curly_hair_icon_159362.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false,
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Luffy",
                    UsernameColor = "#409aff",
                    ImageSource = "https://cdn.icon-icons.com/icons2/2643/PNG/512/male_people_avatar_man_boy_curly_hair_icon_159362.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }
            {
                Messages.Add(new MessageModel
                {
                    Username = "Kwesi",
                    UsernameColor = "#409aff",
                    ImageSource = "https://e7.pngegg.com/pngimages/550/997/png-clipart-user-icon-foreigners-avatar-child-face.png",
                    Message = "Last",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });

                for (int i = 0; i < 5; i++)
                {
                    Contacts.Add(new ContactModel
                    {
                        Username = $"Nana {i}",
                        ImageSource = "https://cdn.icon-icons.com/icons2/2643/PNG/512/male_people_avatar_man_boy_curly_hair_icon_159362.png",
                        Messages = Messages
                    });
                }
            }
        }
    }
}
