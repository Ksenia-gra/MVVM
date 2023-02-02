using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_lab_IndTask
{
     class ViewModel
    {
        public SquareMatrixModel model { get; set; }

        public ViewModel()
        {
            model = new SquareMatrixModel();
        }
    }
}
