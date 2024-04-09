using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace School_Management_System
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Personne _nouvellePersonne;

        public Personne NouvellePersonne
        {
            get { return _nouvellePersonne; }
            set
            {
                _nouvellePersonne = value;
                OnPropertyChanged("NouvellePersonne");
            }
        }

        private ObservableCollection<Personne> _personnes;

        public ObservableCollection<Personne> Personnes
        {
            get { return _personnes; }
            set
            {
                _personnes = value;
                OnPropertyChanged("Personnes");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Personnes = new ObservableCollection<Personne>();
            NouvellePersonne = new Personne();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            if (NouvellePersonne != null && !string.IsNullOrEmpty(NouvellePersonne.Nom))
            {
                Personnes.Add(NouvellePersonne);
                NouvellePersonne = new Personne(); 
            }
            else
            {
                MessageBox.Show("Veuillez remplir le nom de la personne avant d'ajouter");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Students_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Teachers_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Syllabus_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Contact_Click(object sender, RoutedEventArgs e)
        {
        }


    }
}