using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace MVVM_lab_IndTask
{
    internal class SquareMatrixModel : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int size;
        public int Size { get { return size; } set { size = value; OnPropertyChanged("Matrix"); } }
       

        public string Matrix
        {


            get
            {
                
                Random random = new Random();

                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        stringBuilder.Append(random.Next(0, 1000) + "  ");
                    }
                    stringBuilder.Append("\n");
                }
                return stringBuilder.ToString();
            }
            
        }
    }
}
