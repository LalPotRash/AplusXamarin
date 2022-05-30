using System;
using Aplus.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabsPage : TabbedPage
    {
        public TabsPage()
        {
            InitializeComponent();
        }

        private void ProjectEditNavBtn_Clicked(object sender, EventArgs e)
        {
            var project = new Project(ProjectName.Text, "Description", "228000", "@mail.ru", "Kazan");
            Navigation.PushAsync(new EditProjectPage(project));
        }
    }
}