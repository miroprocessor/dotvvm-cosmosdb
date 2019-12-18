using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.Runtime.Filters;
using DotVVMCosmos.Models;
using DotVVMCosmos.Services;

namespace DotVVMCosmos.ViewModels.CRUD
{
    public class EditViewModel : MasterPageViewModel
    {
        private readonly StudentService studentService;

        public StudentDetailModel Student { get; set; }

        public EditViewModel(StudentService studentService)
        {
            this.studentService = studentService;
        }


        public override async Task PreRender()
        {
            Student = await studentService.GetStudentByIdAsync(Context.Parameters["Id"].ToString());

            await base.PreRender();
        }


        public async Task EditStudent()
        {
            await studentService.UpdateStudentAsync(Student);
            Context.RedirectToRoute("CRUD_Detail", new { id = Student.Id });
        }
    }
}
