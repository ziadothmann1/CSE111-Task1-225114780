using System;

namespace CselllTask1
{
    // =========================================================
    // Student Name: ziad othman elasy
    // Academic ID: 225114780
    // Task: CSE111 - Task 1 (Fall 2026-2027)
    // =========================================================

    public class Student
    {
        public int Id { get; set; }
        public Student? Next { get; set; }

        public Student(int id)
        {
            Id = id;
            Next = null;
        }
    }
}
