// CourseCatalog: looks up a course title by its code in one step.
//
// Part E. Build this class along with the Class 3 demo.
public class CourseCatalog
{
    // TODO: Part E. Declare one private field: a Dictionary<string, string>
    // that maps a course code to its title.
    private Dictionary<string, string> courses = new Dictionary<string, string>();

    // TODO: Part E. How many courses are in the catalog.
    public int Count => courses.Count;

    // Adds a course. Returns false, and changes nothing, when the code is
    // already there. Hint: one of the three ways to write does exactly this.
    public bool AddCourse(string code, string title)
    {
        // TODO: Part E, demo
        if (courses.ContainsKey(code))
        {
            return false;
        }
        courses.Add(code, title);
        return true;
        //throw new NotImplementedException();
    }

    // Returns the title for a code, or "(no such course)" when the code is
    // missing. Use TryGetValue, so the code is looked up only once.
    public string TitleFor(string code)
    {
        // TODO: Part E, demo
        if (courses.TryGetValue(code, out string title))
        {
            return title;
        }
        return "(no such course)";
        //throw new NotImplementedException();
    }
}
