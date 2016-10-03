using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabo4.ViewModel
{
    class ViewModelLocator
    {
        //creatyion container + eng de Mainview.. et Secondview à celui-ci
        public ViewModelLocator()
        {
                //Creation container IoC
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SecondViewModel>();

                    //navigatuer de page 
            NavigationService navigationPages = new NavigationService();
            SimpleIoc.Default.Register<NavigationService>(() => navigationPages);
            navigationPages.Configure("MainPage", typeof(MainPage));
            navigationPages.Configure("SecondPage", typeof(SecondPage));

        }


        //retourne instance de MainViewModel

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();

            }
        }

        public SecondViewModel MainSecond
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SecondViewModel>();
            }
        }


    }
}
