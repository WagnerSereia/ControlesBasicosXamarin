using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XF.ControlesBasicos.Classes
{
    public class Configuracao : INotifyPropertyChanged
    {
        public Configuracao()
        {
            aceitaReceberEmail = false;
            EnderecoEmail= "";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnderecoEmail"));
        }

        private bool aceitaReceberEmail;
        public bool AceitaReceberEmail
        {
            get => aceitaReceberEmail;
            set
            {
                if (aceitaReceberEmail != value)
                {
                    aceitaReceberEmail = value;
                    if (!aceitaReceberEmail)
                        EnderecoEmail = "";

                    OnPropertyChanged();
                }
            }
        }
        public string EnderecoEmail { get; set; }
    }
}
