using System;
using System.Collections.Generic;
using System.Collections;

namespace JamesStuartMediaLimited
{
    class Program
    {
        static void Main(string[] args)
        {
            Departments departments = new Departments();
           // Dictionary<string, string> departments = new Dictionary<string, string>();
            departments.Add("Tom Lee", "Training");
            departments.Add("James Anderson", "HR");
            departments.Add("Micheal Chan", "Content Development");
            departments.Add("Jakie Jackson", "Training");
            departments.Add("Bruce Douglas", "Graphics");
            departments.Add("Kim Date", "HR");
            departments.Add("Joseph Mathews", "Content Development");
            departments.Add("Rose Dorson", "Marketing");
            departments.Add("Andrews Stephan", "Graphics");



            departments.GetDetails();


            SortedList depts = new SortedList();
            depts.Add("Tom Lee", "Training"); depts.Add("James Anderson", "HR"); depts.Add("Micheal Chan", "Content Development"); depts.Add("Jakie Jackson", "Training"); depts.Add("Bruce Douglas", "Graphics"); depts.Add("Kim Date", "HR"); depts.Add("Joseph Mathews", "Content Development"); depts.Add("Rose Dorson", "Marketing"); depts.Add("Andrews Stephan", "Graphics");

            
            Console.WriteLine(depts.Contains("Andrews Stephan"));

            depts.Remove("Andrews Stephan");

            Console.WriteLine(depts.Contains("Andrews Stephan"));


            foreach (DictionaryEntry dept in depts)
            {
                Console.WriteLine($"{dept.Key} {dept.Value}");
            }



            // foreach (string key in departments.Keys)
            // {
            //   Console.WriteLine(key+ ":" + departments[key]);
            // }
        }
    }
}
