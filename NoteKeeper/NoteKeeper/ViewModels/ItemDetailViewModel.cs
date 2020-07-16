using System;
using System.Collections.Generic;
using NoteKeeper.Models;

namespace NoteKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public String NoteHeading
        {
            get { return Note.Heading; }
            set 
            { 
                Note.Heading = value; 
                OnPropertyChanged(); // handles the notification of a changed heading
            }
        }


        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            InitializeCourseList();
            Note = new Note { Heading = "Test note", Text = "Text for note in ViewModel", Course = CourseList[0]
        };
           
        }

        async void InitializeCourseList()
        {
            CourseList = await PluralsightDataStore.GetCoursesAsync();
        }

    }
}
