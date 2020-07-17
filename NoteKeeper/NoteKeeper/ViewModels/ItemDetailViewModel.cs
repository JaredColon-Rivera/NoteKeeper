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


        public ItemDetailViewModel(Note note = null)
        {
            Title = "Edit note";
            InitializeCourseList();
            Note = note ?? new Note();
        }

        async void InitializeCourseList()
        {
            CourseList = await PluralsightDataStore.GetCoursesAsync();
        }

    }
}
