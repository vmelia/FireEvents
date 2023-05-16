using FireEvents.Shared;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FireEventsApp
{
    public partial class MainPage
    {
        private readonly IEventTracker _eventTracker;

        public MainPage()
        {
            InitializeComponent();
            _eventTracker = DependencyService.Get<IEventTracker>();
        }

        private void OnButton01Clicked(object sender, EventArgs e)
        {
            _eventTracker.SendEvent("Click01");
        }

        private void OnButton02Clicked(object sender, EventArgs e)
        {
            _eventTracker.SendEvent("Click02", "Comment", "Hello Events");
        }

        private void OnButton03Clicked(object sender, EventArgs e)
        {
            var dictionary = new Dictionary<string, string>
            {
                {"Name", "John Xamarin"},
                {"Phone", "55 555 555 555"},
                {"Email", "johnxamarin@john.com"}
            };
            _eventTracker.SendEvent("Click03", dictionary);
        }
    }
}
