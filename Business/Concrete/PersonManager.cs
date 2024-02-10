using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
                                        //PersonalManager vatandaşa yani kullınıcıya maske verdiğim bir ortam sunuyor olacak 
    {                                  //fonkisyonlar,metodlar,prosedürler 
            public void ApplyForMask(Person person)
            {

            }

            public List<Person> GetList()
            {
                return null;
            }

            public bool CheckPerson(Person person)      //Mernis kontrolü yapılacak
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

                return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirsName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
            }

        

    }
}
