using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.Collections;
using System.Collections.Generic;
using NoteKeeper.Services;

namespace NoteKeeper.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();
           
            BindingContext = Note;
            NoteCourse.BindingContext = this; // referencing our item detail page
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();
           
            BindingContext = Note;
            NoteCourse.BindingContext = this; // referencing our item detail page
        }

        async private void InitializeData()
        {

            var pluralsightDataStore = new MockPluralsightDataStore();
            CourseList = await pluralsightDataStore.GetCoursesAsync();

            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for the test note",
                Course = CourseList[0]
            };
        }

        private void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Cancel Option", "Cancel was selected", "Button2", "Button1");
        }

        private void Save_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save Option", "Save was selected", "Button2", "Button1");
        }

    }
}