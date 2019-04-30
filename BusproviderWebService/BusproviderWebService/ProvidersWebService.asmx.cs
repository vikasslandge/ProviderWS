using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Runtime.Serialization.Json;

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
        

        
        //Insert provider details into 'ProviderDetails' table present in 'providerWS_DB' database
        
        //Below method Inserts bus details into 'BusProviderDetails' and 'BusDetails' table present in 'providerWS_DB' database
        [WebMethod]
        public void InsertBusDetails(string busName, int capacity,string type,string busNo)
        {
            entities.InsertBusDetails(busNo, busName, capacity, type);
          
        }

        [WebMethod]
        public  Boolean DeleteBus(int busId)
        {
            //var busId = entities.BusDetails.Where(n => n.BusNo == busNo).Select(no=> no.BusId).Single();
            var result= entities.DeleteBusRecord(busId);
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
        public Boolean AddCityDetails(string city, string state)
        {
            var result = entities.InsertCityDetails(city,state);
            if (result > 0)
            {
                return true;

            }
            return false;
        }

        [WebMethod]
        public GetCityDetails_Result[] GetCityDetails()
        {
            return entities.GetCityDetails().ToArray();
        }
        [WebMethod]
        public Boolean AddRouteDetails(int busId,int sourceId,int destinationId,DateTime dateOfJourney,double price,TimeSpan arrivalTime, TimeSpan departureTime)
        {
            var result = entities.AddRouteDetails(busId,sourceId,destinationId,dateOfJourney,price,arrivalTime,departureTime);
            if (result > 0)
            {
                return true;

            }
            return false;
        }

        [WebMethod]
        public GetRouteDetails_Result[] GetRouteDetails(int sourceId, int destinationId,DateTime dateOfJourney)
        {
            var result = entities.GetRouteDetails(sourceId, destinationId, dateOfJourney) ;



            return result.ToArray();
                
        }
        [WebMethod]
        public GetBookingStatus_Result[] GetBookingStatuses(int  busId)
        {

            return entities.GetBookingStatus(busId).ToArray();
        }

        [WebMethod]
        public Boolean BookTicket(int busId, int sourceId, int destinationId, DateTime dateOfJourney, double price, TimeSpan arrivalTime, TimeSpan departureTime)
        {
            var result = entities.AddRouteDetails(busId, sourceId, destinationId, dateOfJourney, price, arrivalTime, departureTime);
            if (result > 0)
            {
                return true;

            }
            return false;
        }
    }
 }
