using ClassLibraryTask.OldModels.Planner;
using Spectre.Console;
using System;

namespace ClassLibraryTask.OldModels.Menu
{
    public class MenuOptionsPlanner<T> : MenuOptions
    {
        public UniversityPlanner universityPlanner = new UniversityPlanner();
        public HolidayPlanner holidayPlanner = new HolidayPlanner();

        public new TasksClass<TaskClass> tt { get; set; }

        public override void AddTaskOption(string name, string description, string type, DateTime date)
        {
            base.AddTaskOption(name, description, type, date);
            universityPlanner.Tasks = base.tt;
        }

        public void CreatePlanner (Planner.Planner planner, string typeOfPlanner)
        {
            if (typeOfPlanner == "university")
            {
                universityPlanner = new UniversityPlanner(planner.Name, planner.Description, new TasksClass<TaskClass>(), new TasksClass<TaskClass>());
            }
            else if (typeOfPlanner == "holiday")
            {
                holidayPlanner = new HolidayPlanner(planner.Name, planner.Description, planner.Tasks);
            }
        }

        public void ReadPlanner (string typeOfPlanner)
        {
            var table = new Table();
            

            if (typeOfPlanner == "university")
            {
                table.AddColumn(new TableColumn("Name").Centered());
                table.AddColumn(new TableColumn("Description").Centered());
                //table.AddColumn(new TableColumn("Important tasks").Centered());
                //table.AddColumn(new TableColumn("Tasks").Centered());

                table.AddRow(universityPlanner.Name.ToString(), universityPlanner.Description.ToString());
                //AnsiConsole.Write(th);
                AnsiConsole.Write(table);
                foreach (var item in universityPlanner.Tasks.Tasks)
                {
                    Console.WriteLine(item);
                }
                
            }
            else if (typeOfPlanner == "holiday")
            {
                //th.AddRow("University planner");
                table.AddColumn(new TableColumn("Name").Centered());
                table.AddColumn(new TableColumn("Description").Centered());
                table.AddColumn(new TableColumn("Important tasks").Centered());
                table.AddColumn(new TableColumn("Tasks").Centered());

                table.AddRow(universityPlanner.Name.ToString(), universityPlanner.Description.ToString());
                //AnsiConsole.Write(th);
                AnsiConsole.Write(table);
            }
            
            
        }

        

        public void EditPlanner (Planner.Planner planner, string typeOfPlanner)
        {

        }

        public void DeletePlanner (string typeOfPlanner)
        {
            if (typeOfPlanner == "university")
            {
                universityPlanner = new UniversityPlanner();
            }
            else if (typeOfPlanner == "holiday")
            {
                holidayPlanner = new HolidayPlanner();
            }
        }
    }
}
