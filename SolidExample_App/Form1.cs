using SolidExample_App.Base;
using SolidExample_App.Commands;
using SolidExample_App.Contexts;
using SolidExample_App.Entities;
using SolidExample_App.Enums;
using SolidExample_App.Factories;
using SolidExample_App.Handlers;
using SolidExample_App.Queries;
using SolidExample_App.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidExample_App
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        void FillCombobox()
        {

            cmbAssign.Items.Clear();
            cmbTeamMember.Items.Clear();
            cmbFilterAssign.Items.Clear();
            cmbFilterTaskState.Items.Clear();
            cmbTaskState.Items.Clear();

            foreach (var item in Enum.GetValues(typeof(TaskState)))
            {
                cmbTaskState.Items.Add(item);
                cmbFilterTaskState.Items.Add(item);
            }


            UserRepository userRepo = UserRepositoryFactory.GetInstance();

             List<User> userList =  userRepo.GetAll();

            cmbAssign.Items.AddRange(userList.ToArray());
            cmbFilterAssign.Items.AddRange(userList.ToArray());
            cmbTeamMember.Items.AddRange(userList.ToArray());

            this.flwOperation.Visible = false;


        }

        void FillTable()
        {
            this.lstTaskList.Items.Clear();

            TaskRepository taskRepo = TaskRepositoryFactory.GetInstance();
            List<Entities.Task> taskList= taskRepo.GetAll();

            foreach (var item in taskList)
            {
                ListViewItem li = new ListViewItem();

                li.Text = item.Title;
                li.SubItems.Add(item.Hour.ToString());
                li.SubItems.Add((Enum.Parse(typeof(TaskState), item.State.ToString()).ToString()));
                li.SubItems.Add(item.User?.Name + " " + item.User?.Surname);
                li.Tag = item;

                lstTaskList.Items.Add(li);
            }

        }


        void FillFilteredTable(List<Entities.Task> filteredTasks)
        {

            lstTaskList.Items.Clear();

            foreach (var item in filteredTasks)
            {
                ListViewItem li = new ListViewItem();

                li.Text = item.Title;
                li.SubItems.Add(item.Hour.ToString());
                li.SubItems.Add((Enum.Parse(typeof(TaskState), item.State.ToString()).ToString()));
                li.SubItems.Add(item.User?.Name + " " + item.User?.Surname);
                li.Tag = item;

                lstTaskList.Items.Add(li);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FillCombobox();
            FillTable();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            int hour = (int)nmrHour.Value;

            User assigned_user = (User)cmbAssign.SelectedItem;

            int? assigned_UserId = null;

            if (assigned_user != null)
            {
                assigned_UserId = assigned_user.Id;
            }

            TaskCreateCommand command = new TaskCreateCommand(title, description, assigned_UserId, hour);


             TaskCreateHandler handler = TaskCreateHandlerFactory.GetInstance();

              ResponseBase response= handler.Execute(command);


              MessageBox.Show(response.Message);

             FillTable();



        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (lstTaskList.FocusedItem != null && cmbTeamMember.SelectedItem != null)
            {
               User selected_teamMember  = (User)cmbTeamMember.SelectedItem;
               Entities.Task selected_task  =(Entities.Task)lstTaskList.FocusedItem.Tag;

                if (selected_task != null && selected_teamMember != null)
                {
                    TaskAssignCommand command = new TaskAssignCommand(selected_task.Id, selected_teamMember.Id);

                    TaskAssignHandler handler  =  TaskAssignHandlerFactory.GetInstance();

                    ResponseBase response = handler.Execute(command);

                    MessageBox.Show(response.Message);

                    FillTable();

                }

            }
        }

        //Odev
        private void btnTaskStateChange_Click(object sender, EventArgs e)
        {
            if (lstTaskList.FocusedItem != null && cmbTaskState.SelectedItem != null)
            {
                Entities.Task selected_task  = (Entities.Task)lstTaskList.FocusedItem.Tag;

                TaskState selected_taskState = (TaskState)cmbTaskState.SelectedItem;

                if (selected_taskState == TaskState.Done)
                {
                    TaskDoneCommand command = new TaskDoneCommand(selected_task.Id);
                    TaskDoneHandler handler = TaskDoneHandlerFactory.GetInstance();

                    ResponseBase response = handler.Execute(command);

                    MessageBox.Show(response.Message);
                }
                else if (selected_taskState == TaskState.InProgress)
                {
                    TaskInProgressCommand command = new TaskInProgressCommand(selected_task.Id);

                    TaskInProgressHandler handler = TaskInprogressHandlerFactory.GetInstance();

                    ResponseBase response = handler.Execute(command);

                    MessageBox.Show(response.Message);


                }
                else if (selected_taskState == TaskState.Test)
                {
                    TaskTestCommand command = new TaskTestCommand(selected_task.Id);
                    TaskTestHandler handler = TaskTestHandlerFactory.GetInstance();

                    ResponseBase response = handler.Execute(command);

                    MessageBox.Show(response.Message);
                }
                else if (selected_taskState == TaskState.Todo)
                {
                    TaskTodoCommand command = new TaskTodoCommand(selected_task.Id);

                    TaskTodoHandler handler = TaskTodoHandlerFactory.GetInstance();

                    ResponseBase response = handler.Execute(command);

                    MessageBox.Show(response.Message);
                }

                FillTable();

            }
        }

        private void lstTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.flwOperation.Visible = true;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbFilterTaskState.SelectedItem != null && cmbFilterAssign.SelectedItem != null)
            {

                User selected_user = (User)cmbFilterAssign.SelectedItem;
                TaskState selected_taskSate = (TaskState)cmbFilterTaskState.SelectedItem;


                GetTaskSpecificUserAndTaskStateQuery query = new GetTaskSpecificUserAndTaskStateQuery(selected_user.Id, selected_taskSate);

                GetTaskSpecificUserAndTaskStateQueryHandler handler = GetTaskSpecificUserAndTaskStateQueryHandlerFactory.GetInstance();

                List<Entities.Task> filteredTasks = handler.Execute(query);

                FillFilteredTable(filteredTasks);
            }
            else if (cmbFilterTaskState.SelectedItem != null && cmbFilterAssign.SelectedItem == null)
            {

                TaskState selected_taskSate = (TaskState)cmbFilterTaskState.SelectedItem;

                GetTaskSpecificTaskStateQuery query = new GetTaskSpecificTaskStateQuery(selected_taskSate);

                GetTaskSpecificTaskStateQueryHandler handler = GetTaskSpecificTaskStateQueryHandlerFactory.GetInstance();
                List<Entities.Task> filteredTasks = handler.Execute(query);


                FillFilteredTable(filteredTasks);
            }
            else if (cmbFilterTaskState.SelectedItem == null && cmbFilterAssign.SelectedItem != null)
            {
                User selected_user = (User)cmbFilterAssign.SelectedItem;

                GetTaskSpecificUserQuery query = new GetTaskSpecificUserQuery(selected_user.Id);

                GetTaskSpecificUserQueryHandler handler = GetTaskSpecificUserQueryHandlerFactory.GetInstance();

                List<Entities.Task> filteredTasks = handler.Execute(query);

                FillFilteredTable(filteredTasks);
            }
            else
            {
                FillTable();
            }
        }
    }
}
