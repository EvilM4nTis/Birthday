using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace Birthday.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        string baseUri = "ms-appx:///";
        public MainViewModel()
        {
            Images = new ObservableCollection<Uri>();
            Images.Add(new Uri(baseUri + "Images/1.png"));
            Images.Add(new Uri(baseUri + "Images/2.png"));
            Images.Add(new Uri(baseUri + "Images/3.png"));
            Images.Add(new Uri(baseUri + "Images/4.png"));
            Images.Add(new Uri(baseUri + "Images/5.png"));
            Images.Add(new Uri(baseUri + "Images/6.png"));
            Images.Add(new Uri(baseUri + "Images/7.png"));
            Images.Add(new Uri(baseUri + "Images/8.png"));
            Images.Add(new Uri(baseUri + "Images/9.png"));
            Images.Add(new Uri(baseUri + "Images/11.jpg"));
            Images.Add(new Uri(baseUri + "Images/12.jpg"));
            Images.Add(new Uri(baseUri + "Images/13.jpg"));
            Images.Add(new Uri(baseUri + "Images/14.jpg"));
            Images.Add(new Uri(baseUri + "Images/15.jpg"));
            Images.Add(new Uri(baseUri + "Images/16.jpg"));
        }

        
        public ObservableCollection<Uri> Images
        {
            get;
            set;
        }

    }
}