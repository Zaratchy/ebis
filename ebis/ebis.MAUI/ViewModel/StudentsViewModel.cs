﻿using ebis.MAUI.Model;

namespace ebis.MAUI.ViewModel;



public class StudentsViewModel
{
    private List<Students> studentsCollection = new List<Students>();

    public StudentsViewModel()
    {
        studentsCollection.Add(new Students("Marie", "White", "+1-809-554-6055"));
        studentsCollection.Add(new Students("Paola", "Pullman", "+1-809-506-5655"));
        studentsCollection.Add(new Students("Joseph", "McDonalds", "+1-809-684-4876"));
    }

    public List<Students> StudentsCollection
    {
        get { return studentsCollection; }
        set { studentsCollection = value; }
    }
}
