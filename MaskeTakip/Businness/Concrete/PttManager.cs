using Businness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantservice;
        

        public PttManager(IApplicantService applicantService)
        {
            _applicantservice = applicantService;   
        }

      
        public void GiveMask(Person person)
        {
         
       
            if (_applicantservice.CheckPerson(person)) {
                Console.WriteLine(person.FirstName +  "için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName +   "için maske verilemedi");
            }
        }
    }
    
}
