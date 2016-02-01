using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestUniversalApp
{

    interface IVisitor
    {
        void VisitPersonAcc(Person acc);
       
        void VisitCompanyAc(Company acc);
      
    }

    //html
    class HtmlVisitor : IVisitor
    {

      

        public void VisitCompanyAc(Company acc)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>RegNumber<td><td>" + acc.RegNumber + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>";
            Debug.WriteLine(result);
           
        }

        public void VisitPersonAcc(Person acc)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>FIO<td><td>" + acc.FIO + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.AccNumber + "</td></tr></table>";
            Debug.WriteLine(result);
          
        }
    }

    class XmlVisitor : IVisitor
    {
      
        public void VisitCompanyAc(Company acc)
        {
            string result = "<Company><Name>" + acc.Name + "</Name>" +
          "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
          "<Number>" + acc.Number + "</Number><Company>";
            Debug.WriteLine(result);
        
        }

        public void VisitPersonAcc(Person acc)
        {
            string result = "<Person><Name>" + acc.FIO + "</Name>" +
        "<Number>" + acc.AccNumber + "</Number><Person>";
            Debug.WriteLine(result);
         
        }
    }

    interface IAccount
    {
        void Accept(IVisitor visitor);
    }

    class Person : IAccount
    {
        public string FIO { get; set; }
        public string AccNumber { get; set; }

        public void Accept(IVisitor visitor)
        {
            if (visitor != null)
                visitor.VisitPersonAcc(this);
        }
    }

    class Company : IAccount
    {
        public string Name { get; set; } // название
        public string RegNumber { get; set; } // гос регистрационный номер
        public string Number { get; set; } // номер счета

        public void Accept(IVisitor visitor)
        {

            if (visitor != null)
                visitor.VisitCompanyAc(this);
        }
    }

    class Bank
    {
        List<IAccount> accounts = new List<IAccount>();
        public void Add(IAccount acc)
        {
            accounts.Add(acc);
        }
        public void Remove(IAccount acc)
        {
            accounts.Remove(acc);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (IAccount acc in accounts)
                acc.Accept(visitor);
        }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            EngineWriperUniversal.ManagedDllWrapperImp wraper = new EngineWriperUniversal.ManagedDllWrapperImp();
            var value = wraper.DivideWrapper(2, 0);

            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            var structure = new Bank();
            structure.Add(new Person { FIO = "Иван Алексеев", AccNumber = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });

            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            base.OnNavigatedTo(e);  
        }


    }
}
