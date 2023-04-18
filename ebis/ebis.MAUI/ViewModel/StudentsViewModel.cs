using ebis.MAUI.Model;

namespace ebis.MAUI.ViewModel;

public class BornesViewModel
{
    private List<Bornes> bornesCollection = new List<Bornes>();

    public BornesViewModel()
    {
        bornesCollection.Add(new Bornes("Marie", "White", "+1-809-554-6055"));
        bornesCollection.Add(new Bornes("Paola", "Pullman", "+1-809-506-5655"));
        bornesCollection.Add(new Bornes("Joseph", "McDonalds", "+1-809-684-4876"));
    }

    public List<Bornes> StudentsCollection
    {
        get { return bornesCollection; }
        set { bornesCollection = value; }
    }
}
