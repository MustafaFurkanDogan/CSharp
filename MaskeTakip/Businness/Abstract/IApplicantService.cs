using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{//Sonar Qube = yazılım kalitesi için kullanılan uygulama
    public  interface IApplicantService
    {
         void ApplyFormMask(Person person)
        {


        }

         List<Person> GetList()
        {

            return null;

        }

        bool CheckPerson(Person person)
        {

            return true;
        }
    }
}
