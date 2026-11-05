using System;

namespace CselllTask1
{
    // =========================================================
    // Student Name: ziad othman elasy
    // Academic ID: 225114780
    // Task: CSE111 - Task 1 (Fall 2026-2027)
    // =========================================================

    public class StudentList
    {
        public Student? First { get; private set; }
        public Student? Last { get; private set; }
        public int Count { get; private set; }

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        // O(1) - Put student at the front
        public void AddFront(int id)
        {
            Student newStudent = new Student(id);
            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }
            Count++;
        }

        // O(1) - Put student at the end using Last pointer
        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);
            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                Last!.Next = newStudent;
                Last = newStudent;
            }
            Count++;
        }

        // O(n) - Drop the first match
        public bool Remove(int id)
        {
            if (First == null) return false;

            Student? current = First;
            Student? previous = null;

            while (current != null)
            {
                if (current.Id == id)
                {
                    if (previous == null) // Removing First
                    {
                        First = First.Next;
                        if (First == null) Last = null;
                    }
                    else // Removing Middle or Last
                    {
                        previous.Next = current.Next;
                        if (current == Last) Last = previous;
                    }

                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        // O(n) - Turn the line around in-place
        public void Reverse()
        {
            if (First == null || First.Next == null) return;

            Student? prev = null;
            Student? current = First;
            Student? next = null;

            Last = First; // Old First becomes new Last

            while (current != null)
            {
                next = current.Next; // Save Next node
                current.Next = prev; // Reverse link
                prev = current;
                current = next;
            }

            First = prev; // Set new First node
        }

        // O(n) - Print student IDs separated by space
        public void Print()
        {
            Student? current = First;
            while (current != null)
            {
                Console.Write(current.Id + (current.Next != null ? " " : ""));
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
