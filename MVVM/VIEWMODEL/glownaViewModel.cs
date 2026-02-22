using MenagerLekow.MVVM.MODEL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MenagerLekow.MVVM.VIEWMODEL
{
    public class glownaViewModel
    {
        ObservableCollection<HarmonogramDTO> collection = new ObservableCollection<HarmonogramDTO>();
        public glownaViewModel()
        {
            
        }
    }
}
