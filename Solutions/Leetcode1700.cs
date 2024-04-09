
namespace LeetcodeSharp.Solutions; 
public  class Leetcode1700 {

    // just simulate the student behaviour, slow but interesting :)
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> studentQueue = new(students);
        Stack<int> sandwichStack = new (sandwiches.Reverse());
        int tryTake = 0;
        while (studentQueue.Count > 0) {
            if(studentQueue.Peek() == sandwichStack.Peek()) { 
                // take the sandwich and leave...
                studentQueue.Dequeue();
                sandwichStack.Pop();
                tryTake = 0;
            }
            else {
                // student dont take and go to the last of the queue...
                int student = studentQueue.Dequeue();
                studentQueue.Enqueue(student);
                tryTake++;
                if(tryTake > studentQueue.Count) {
                    return studentQueue.Count;
                }
            }
            
        }
        // All sandwitches are taken.
        return 0;
    }
}
