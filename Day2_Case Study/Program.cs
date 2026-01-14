// See https://aka.ms/new-console-template for more information
//Case study Using Arrays to Manage Student Grades
//if i want to store marks of students in different subjects: "Subject wise marks for each student"
//Step 1: Declare a 20 array to store marks of 3 students in 4 subjects
//Step 2. Initialize the array with sample marks
//Step 3: Calculate and print the average marks for each student
//Step 4: Calculate and print the average marks for each subject
//Step 5: Find and print the highest and lowest marks in the class Syntax for declaraing 20 array as per above sceanrio is
// dataType[,] arrayName = new dataType[rows, columns];
// ther is a differenec between storing marks and storing subject wise marks for each student
//In first case each row represents a student and each column represents a subject
//In second case each row represents a subject and each column represents a student
using System;

class StudentGrades
{
    static void Main()
    {
        // Declare and initialize array
        double[,] marks = new double[4, 3] {
            { 90, 85, 95 }, // Subject 1
            { 80, 75, 85 }, // Subject 2
            { 70, 65, 75 }, // Subject 3
            { 95, 90, 85 }  // Subject 4
        };

        // Average marks per student
        Console.WriteLine("Average marks per student:");
        for (int col = 0; col < 3; col++)
        {
            double sum = 0;
            for (int row = 0; row < 4; row++)
            {
                sum += marks[row, col];
            }
            Console.WriteLine($"Student {col + 1}: {sum / 4}");
        }

        // Average marks per subject
        Console.WriteLine("\nAverage marks per subject:");
        for (int row = 0; row < 4; row++)
        {
            double sum = 0;
            for (int col = 0; col < 3; col++)
            {
                sum += marks[row, col];
            }
            Console.WriteLine($"Subject {row + 1}: {sum / 3}");
        }
    }
}

        // Highest and lowest marks double
        