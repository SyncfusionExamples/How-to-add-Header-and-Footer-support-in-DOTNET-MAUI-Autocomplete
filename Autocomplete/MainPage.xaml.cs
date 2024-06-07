using System.Collections.ObjectModel;

namespace Autocomplete {
    public partial class MainPage : ContentPage {
       

        public MainPage() {
            InitializeComponent();
        }
    }


    public class SocialMedia {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public class SocialMediaViewModel {
       
        public ObservableCollection<SocialMedia> SocialMedias { get; set; }
        public SocialMediaViewModel() {
            this.SocialMedias = new ObservableCollection<SocialMedia>();
            this.SocialMedias.Add(new SocialMedia() { Name = "Facebook", ID = 0 });
            this.SocialMedias.Add(new SocialMedia() { Name = "Google Plus", ID = 1 });
            this.SocialMedias.Add(new SocialMedia() { Name = "Instagram", ID = 2 });
            this.SocialMedias.Add(new SocialMedia() { Name = "LinkedIn", ID = 3 });
            this.SocialMedias.Add(new SocialMedia() { Name = "Skype", ID = 4 });
            this.SocialMedias.Add(new SocialMedia() { Name = "Telegram", ID = 5 });
            this.SocialMedias.Add(new SocialMedia() { Name = "Televzr", ID = 6 });
            this.SocialMedias.Add(new SocialMedia() { Name = "Tik Tok", ID = 7 });
            this.SocialMedias.Add(new SocialMedia() { Name = "Tout", ID = 8 });
        }

    }

}
