using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _appicantService;

        public PttManager(IApplicantService applicantService)     //Constructor PttManager new yapıldığında önce çalışır
        {
            _appicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
           
            if (_appicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirsName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirsName + " için maske VERİLEMEDİ");
            }
        }
    }
}
