using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExemploTrigger
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        private string _Nome = String.Empty;
        public string Nome
        {
            get => _Nome;
            set => SetProperty(ref _Nome, value);
        }

        private string _SobreNome = String.Empty;
        public string SobreNome
        {
            get => _SobreNome;
            set => SetProperty(ref _SobreNome, value);
        }

        private string _Login = String.Empty;
        public string Login
        {
            get => _Login;
            set => SetProperty(ref _Login, value);
        }

        private string _Senha = String.Empty;
        public string Senha
        {
            get => _Senha;
            set => SetProperty(ref _Senha, value);
        }
    }
}
