// OfficeHours: fair office hours. Everyone in line gets a turn of at most
// slice minutes, and anyone who still needs time goes to the back of the
// line.
//
// Part D. Run is Exercise 4.
public static class OfficeHours
{
    // Start the clock at 0. Until the line is empty:
    //   1. take the student at the front of the line
    //   2. help them for one turn and add the minutes used to the clock
    //   3. if they still need time, send them to the back of the line;
    //      otherwise add "<Name> done at minute <clock>" to the result
    // Return the result list. Do not print anything here.
    public static MyList<string> Run(MyQueue<Visit> line, int slice)
    {
        
        MyList<string> results = new MyList<string>();
        // TODO: Part D, Exercise 4
        

        int currentTime = 0;

        while (!line.IsEmpty) 
        {
            Visit student = line.Dequeue();
            int turn = Math.Min(slice, student.MinutesLeft);

            currentTime += (turn);
            student.Help(turn);
            if (student.MinutesLeft > 0)
            {
                line.Enqueue(student);
            }
            else
            {
                results.Add(student.Name + " done at " + currentTime + " minutes ");
            }
            
        }
        return results;
        
    }
}
