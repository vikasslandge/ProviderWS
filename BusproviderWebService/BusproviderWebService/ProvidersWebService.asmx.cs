using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BusproviderWebService
{
    /// <summary>
    /// Summary description for ProvidersWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProvidersWebService : System.Web.Services.WebService
    {
        ProvidersWS_DBEntities entities = new ProvidersWS_DBEntities();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public GetProviderDetails_Result[] GetProviderDetails()
        {
            return entities.GetProviderDetails().ToArray();
        }
        //Insert provider details into 'ProviderDetails' table present in 'providerWS_DB' database
        [WebMethod]
        public void InsertIntoProvider(string name,string contact)
        {   
            ProviderDetail providerDetail = new ProviderDetail()
            {   
                OrganisationName = name,
                ContactNo =  contact
            };
            entities.ProviderDetails.Add(providerDetail);
            entities.SaveChanges();
        }
        //Below method Inserts bus details into 'BusProviderDetails' and 'BusDetails' table present in 'providerWS_DB' database
        [WebMethod]
        public void InsertBusDetails(string busName, int capacity,string type,string busNo, int providerId)
        {
            entities.InsertBusDetails(busNo, busName, capacity, type, providerId);
          
        }

        [WebMethod]
        public  Boolean DeleteBus(string busNo)
        {
            //var busId = entities.BusDetails.Where(n => n.BusNo == busNo).Select(no=> no.BusId).Single();
            var result= entities.DeleteBusRecord(busNo);
            if (result>0)
            {
                return true;
                
            }
            return false;
        }
        [WebMethod]
        public Boolean BookSeat(int seatNo,int busId,string seatStatus)
        {
            var result = entities.BookSeat(seatNo, busId, seatStatus);
            if (result > 0)
            {
                return true;

            }
            return false;
        }
        [WebMethod]
        public Boolean ChangeSeatType(int seatNo, int busId, string seatType)
        {
            var result = entities.ChangeSeatType(seatNo, busId, seatType);
            if (result > 0)
            {
                return true;

            }
            return false;
        }
        [WebMethod]
        public GetBusDetails_Result[] GetBusDetails()
        {
            return entities.GetBusDetails().ToArray();
        }
        [WebMethod]
        public GetBusProviderDetails_Result[] GetBusProviderDetails()
        {
            return entities.GetBusProviderDetails().ToArray();
        }
    }
 }
